using FunTODOLogic.Adapters;
using FunTODOLogic.Providers;
using FunTODOModels.Entity;
using FunTODOWebSite.Controllers;
using FunTODOWebSite.Models.Entity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FunTODO.Controllers
{
    public class TodoController : BaseController
    {
        private readonly ITodoProvider TodoProvider;
        private readonly IDomainToApplicationAdapter<TodoList, TodoListViewModel> TodoListAdapter;
        public TodoController(ITodoProvider TodoProvider, IDomainToApplicationAdapter<TodoList, TodoListViewModel> todoListAdapter)
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
        /// Provides a single TODO list by id for a user
        /// </summary>
        /// <returns></returns>
        [Route("Todo/TodoList/{userID?}")]
        [Authenticate]
        public IActionResult TodoList(string listID)
        {
            var claims = HttpContext.User.Claims;
            bool isauthenticated = HttpContext.User.Identity.IsAuthenticated;
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);//signout user

            var todoListViewModel = TodoListAdapter.ConvertToApplication(TodoProvider.GetTodoListForUserID(listID,base.GetUser()));
            return View(todoListViewModel);
        }
    }
}