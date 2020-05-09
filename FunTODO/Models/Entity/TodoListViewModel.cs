using FunTODOModels.Entity;
using System.Collections.Generic;

namespace FunTODOWebSite.Models.Entity
{
    public class TodoListViewModel : IApplicationModel
    {
        public IList<TodoItem> todoList;
        public string todoTitle;

        public TodoListViewModel(List<TodoItem> todoList)
        {
            this.todoList = todoList;
        }
        public TodoListViewModel(List<TodoItem> todoList, string todoTitle)
        {
            this.todoList = todoList;
            this.todoTitle = todoTitle;
        }
        public TodoListViewModel()
        {

        }
    }
}
