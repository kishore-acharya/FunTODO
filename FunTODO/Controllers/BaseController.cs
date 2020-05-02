using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FunTODOModels.Individual;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FunTODOWebSite.Controllers
{
    public class BaseController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        internal IIndividual GetUser()
        {
            throw new NotImplementedException();
        }
    }
}
