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
        [HttpGet]
        [Route("login/signup")]
        public IActionResult Signup()
        {
            return View();
        }
    }
}