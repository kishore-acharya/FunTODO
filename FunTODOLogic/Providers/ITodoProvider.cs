using FunTODOModels.Entity;

namespace FunTODOLogic.Providers
{
    public interface ITodoProvider : ITodoLogic
    {
        TodoList GetTodoListForUserID(string UserID);
    }
}
