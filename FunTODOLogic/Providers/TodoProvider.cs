using FunTODOModels.Entity;
using FunTODORepository.Entities;

namespace FunTODOLogic.Providers
{
    public class TodoProvider : ITodoProvider
    {
        IEntityListRepository<TodoList> TodoListRepository;
        public TodoProvider(IEntityListRepository<TodoList> TodoListRepository)
        {
            this.TodoListRepository = TodoListRepository;
        }
        public TodoList GetTodoListForUserID(string UserID)
        {
            return TodoListRepository.GetByUserID(UserID);

        }
    }
}

