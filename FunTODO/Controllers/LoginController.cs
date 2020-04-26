using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FunTODOWebSite.Models.Login;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FunTODOWebSite.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        [Route("login/{redirect?}")]
        public IActionResult Login(bool redirect)
        {
            if (redirect)
            {
                ViewBag.redirect = true;
                ViewBag.message = "Login or create an account to access FunTODO"; 
            }
            return View(new LoginModel());
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login(LoginModel login)
        {
            throw new NotImplementedException();

        }
        [HttpGet]
        [Route("login/signup")]
        public IActionResult Signup()
        {
            return View();
        }
    }
}