using FunTODOModels.Entity;
using System.Collections.Generic;

namespace FunTODOWebSite.Models.Entity
{
    public class TodoListViewModel : IApplicationModel
    {
        public IList<TodoItem> todoList;

        public TodoListViewModel(List<TodoItem> todoList)
        {
            this.todoList = todoList;
        }
        public TodoListViewModel()
        {

        }
    }
}
