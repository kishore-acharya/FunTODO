using System.Linq;
using FunTODOLogic.Adapters;
using FunTODOLogic.Providers;
using FunTODOModels.Entity;
using FunTODOWebSite.Models.Entity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FunTODOWebSite.Controllers
{
    public class TodoController : BaseController
    {
        private readonly ITodoProvider TodoProvider;
        private readonly IDomainToApplicationAdapter<TodoList, TodoListViewModel> TodoListAdapter;
        public TodoController(ITodoProvider TodoProvider, IDomainToApplicationAdapter<TodoList, TodoListViewModel> todoListAdapter,IUserProvider userProvider) :base(userProvider)
        {
            this.TodoProvider = TodoProvider;
            this.TodoListAdapter = todoListAdapter;
        }
        [Route("Todo")]
        public IActionResult Main()
        {
            return View();
        }

        /////Todo/TodoList
        /// <summary>
        /// Provides a single Todo list by id for a user
        /// </summary>
        /// <returns></returns>
        [Route("Todo/TodoList")]
        [Authorize(Roles = "NormalUser")]
        public IActionResult TodoList()
        {
            var claims = HttpContext.User.Claims;
            bool isauthenticated = HttpContext.User.Identity.IsAuthenticated;
            var todoListViewModel = TodoListAdapter.ConvertToApplication(TodoProvider.GetAllTodoLists(base.GetUser()).FirstOrDefault());
            return View(todoListViewModel);
        }
    }
}