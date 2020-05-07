using System.Collections.Generic;
using FunTODOModels.Entity;
using FunTODOModels.Individual;

namespace FunTODOLogic.Providers
{
    public interface ITodoProvider : IFunTodoLogic
    {
        IEnumerable<TodoList> GetAllTodoLists(IIndividual individual);
    }
}
