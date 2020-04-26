using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using FunTODOLogic;
using FunTODOModels.Entity;
using FunTODOLogic.Adapters;
using FunTODOLogic.Providers;
using FunTODOWebSite.Models.Entity;

namespace FunTODO.Controllers
{
    public class TodoController : Controller
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
        public IActionResult TodoList(string userID)
        {
            var todoListViewModel = TodoListAdapter.ConvertToApplication(TodoProvider.GetTodoListForUserID(userID));
            return View(todoListViewModel);
        }
    }
}