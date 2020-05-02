using FunTODOModels.Entity;
using FunTODOModels.Individual;

namespace FunTODOLogic.Providers
{
    public interface ITodoProvider : IFunTodoLogic
    {
        TodoList GetTodoListForUserID(string listID, IIndividual individual);
    }
}
