using FunTODODataAccess;
using FunTODOModels.Entity;

namespace FunTODORepository.Entities
{
    public class TodoListRepository : IEntityListRepository<TodoList>
    {
        IDataAccess<TodoList> TodoListDataAccess;
        public TodoListRepository(IDataAccess<TodoList> TodoListDataAccess)
        {
            this.TodoListDataAccess = TodoListDataAccess;
        }

        public TodoList GetByUserID(string ID)
        {
            return TodoListDataAccess.GetByUserID(ID);
        }
    }
}
