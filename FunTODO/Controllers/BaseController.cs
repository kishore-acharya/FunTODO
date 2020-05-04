using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FunTODOLogic.Providers;
using FunTODOModels.Individual;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FunTODOWebSite.Controllers
{
    public class BaseController : Controller
    {
        private readonly IUserProvider userProvider;

        public BaseController(IUserProvider userProvider) 
        {
            this.userProvider = userProvider;
        }

       

        public IIndividual GetUser()
        {
            var user = HttpContext.User;
            if (user.Identity.IsAuthenticated)
            {
                return userProvider.GetUserByUserName(user.Identity.Name);
            }
            return null;
            
        }
    }
}
