using FunTODOLogic.Adapters;
using FunTODOModels.Entity;
using FunTODOWebSite.Models.Entity;

namespace FunTODOWebSite.Adapters
{
    public class TodoListAdapter : IDomainToApplicationAdapter<TodoList, TodoListViewModel>
    {
        public TodoListViewModel ConvertToApplication(TodoList domain)
        {
            var application = new TodoListViewModel();
            application.todoList = domain.Items;
            return application;
        }
    }
}
