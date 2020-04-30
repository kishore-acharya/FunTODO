using FunTODOModels.Entity;

namespace FunTODOLogic.Providers
{
    public interface ITodoProvider : IFunTodoLogic
    {
        TodoList GetTodoListForUserID(string UserID);
    }
}
