using FunTODOLogic.Adapters;
using FunTODOModels.Entity;
using FunTODOWebSite.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunTODOWebSite.Adapters
{
    public class TodoListAdapter : IDomainToApplicationAdapter<TodoList, TodoListViewModel>, IApplicationToDomainAdapter<TodoListViewModel, TodoList>
    {
        public TodoListViewModel ConvertToApplication(TodoList domain)
        {
            var application = new TodoListViewModel();
            application.todoList = domain.Items;
            return application;
        }

        public TodoList ConvertToDomain(TodoListViewModel application)
        {
            var domain = new TodoList();
            throw new NotImplementedException();
        }
    }
}
