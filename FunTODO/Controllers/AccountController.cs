using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Security.Claims;
using System.Threading.Tasks;
using FunTODOLogic.Adapters;
using FunTODOLogic.Providers;
using FunTODOLogic.Security;
using FunTODOModels.Process;
using FunTODOWebSite.Models.Login;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace FunTODOWebSite.Controllers
{
    public class AccountController : Controller
    {
        private IUserProvider userProvider;
        private readonly ILoginProcessor loginProcessor;
        private readonly IApplicationToDomainAdapter<LoginModel, LoginCredentials> loginAdapter;

        public AccountController(IUserProvider userProvider,
            ILoginProcessor loginProcessor,
            IApplicationToDomainAdapter<LoginModel, LoginCredentials> loginAdapter)
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
            return View(new LoginModel { ReturnUrl = returnUrl });
        }

        [HttpPost]
        [Route("account/login/{ReturnUrl?}")]
        public async Task<IActionResult> LoginAsync(LoginModel login)
        {
            if (!ModelState.IsValid) return View(login);
            var authenticated = loginProcessor.VerifyUserByIdPassword(loginAdapter.ConvertToDomain(login));
            if (authenticated)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, login.UserName),
                    new Claim(ClaimTypes.Role, "NormalUser")
                };

                var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties();
                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties);
                if (Url.IsLocalUrl(login.ReturnUrl))
                    return Redirect(login.ReturnUrl);
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpGet]
        [Route("account/logout")]
        [Route("logout")]
        public async Task<IActionResult> LogoutAsync()
        {
            await HttpContext.SignOutAsync();
            return View();
        }
    }
}