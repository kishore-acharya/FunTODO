using FunTODOLogic.Adapters;
using FunTODOLogic.Providers;
using FunTODOModels.Entity;
using FunTODOWebSite.Models.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FunTODOWebSite.Controllers
{
    public class TodoController : BaseController
    {
        private readonly ITodoProvider _todoProvider;
        private readonly IDomainToApplicationAdapter<TodoList, TodoListViewModel> _todoListAdapter;
        public TodoController(ITodoProvider todoProvider, IDomainToApplicationAdapter<TodoList, TodoListViewModel> todoListAdapter, IUserProvider userProvider) : base(userProvider)
        {
            this._todoProvider = todoProvider;
            this._todoListAdapter = todoListAdapter;
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
            var todoListViewModel = _todoListAdapter.ConvertToApplication(_todoProvider.GetAllTodoLists(base.GetUser()).FirstOrDefault());
            return View(todoListViewModel);
        }
    }
}