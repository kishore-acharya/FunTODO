using FunTODOModels.Entity;
using FunTODOWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunTODOWebSite.Models.Entity
{
    public class TodoListViewModel: IApplicationModel
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
