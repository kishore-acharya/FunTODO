using FunTODOWebSite.Models.Login;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FunTODOWebSite.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        [Route("login")]
        public IActionResult Login()
        {
            return View(new LoginModel());
        }
        [HttpPost]
        [Route("login")]
        public IActionResult Login(LoginModel login)
        {
            throw new NotImplementedException();

        }
    }
}