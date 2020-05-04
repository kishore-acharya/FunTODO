using FunTODO.Controllers;
using FunTODOLogic.Adapters;
using FunTODOLogic.Providers;
using FunTODOLogic.Security;
using FunTODOModels.Process;
using FunTODOWebSite.Models.Login;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace FunTODOWebSite.Controllers
{
    public class AccountController : Controller
    {
        private IUserProvider userProvider;
        private ILoginProcessor loginProcessor;
        private IApplicationToDomainAdapter<LoginModel, LoginCredentials> loginAdapter;
        public AccountController(IUserProvider userProvider,
                                ILoginProcessor loginProcessor,
                                IApplicationToDomainAdapter<LoginModel,LoginCredentials> loginAdapter)
        {
            this.userProvider = userProvider;
            this.loginProcessor = loginProcessor;
            this.loginAdapter = loginAdapter;
        }

        [HttpGet]
        [Route("account/login/{ReturnUrl?}")]
        public IActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View(new LoginModel(){ReturnUrl=returnUrl});
        }
        [HttpPost]
        [Route("account/login/{ReturnUrl?}")]
        public async Task<IActionResult> LoginAsync(LoginModel login)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }
            bool authenticated = loginProcessor.VerifyUserByIdPassword(loginAdapter.ConvertToDomain(login));
            if (authenticated)
            {
                var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.NameIdentifier,login.UserName),
                        new Claim(ClaimTypes.Role, "NormalUser"),
                    };

                var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties
                {
                    //AllowRefresh = <bool>,
                    // Refreshing the authentication session should be allowed.

                    //ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
                    // The time at which the authentication ticket expires. A 
                    // value set here overrides the ExpireTimeSpan option of 
                    // CookieAuthenticationOptions set with AddCookie.

                    //IsPersistent = true,
                    // Whether the authentication session is persisted across 
                    // multiple requests. When used with cookies, controls
                    // whether the cookie's lifetime is absolute (matching the
                    // lifetime of the authentication ticket) or session-based.

                    //IssuedUtc = <DateTimeOffset>,
                    // The time at which the authentication ticket was issued.

                    //RedirectUri = <string>
                    // The full path or absolute URI to be used as an http 
                    // redirect response value.
                };
                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties);
                if (Url.IsLocalUrl(login.ReturnUrl))
                {
                    return Redirect(login.ReturnUrl);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
               
            }

            return View();

        }

        [HttpGet]
        [Route(("account/logout"))]
        [Route("logout")]
        public async Task<IActionResult> LogoutAsync()
        {
            await HttpContext.SignOutAsync();
            return View();
            //return RedirectToAction("Index", "Home");
        }
    }
}