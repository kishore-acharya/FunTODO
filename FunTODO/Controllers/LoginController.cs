using FunTODOLogic.Providers;
using FunTODOWebSite.Models.Login;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FunTODOWebSite.Controllers
{
    public class LoginController : Controller
    {
        private IUserProvider userProvider;

        public LoginController(IUserProvider userProvider)
        {
            this.userProvider = userProvider;
        }
        [HttpGet]
        [Route("login")]
        public IActionResult Login()
        {
            var usertemp = userProvider.GetUserByUserName("alinder0");
            var loginViewModel = new LoginModel();
            loginViewModel.UserName = usertemp.UserID;
            loginViewModel.Password = usertemp.Password;
            return View(loginViewModel);
        }
        [HttpPost]
        [Route("login")]
        public IActionResult Login(LoginModel login)
        {
            throw new NotImplementedException();

        }
    }
}