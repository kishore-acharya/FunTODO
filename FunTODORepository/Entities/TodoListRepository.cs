using FunTODODataAccess;
using FunTODOModels.Entity;
using FunTODOModels.Individual;
using System.Collections.Generic;

namespace FunTODORepository.Entities
{
    public class TodoListRepository : IEntityRepository<TodoList, IIndividual>
    {
        IEntityDataAccess<TodoList> TodoListDataAccess;
        public TodoListRepository(IEntityDataAccess<TodoList> TodoListDataAccess)
        {
            this.TodoListDataAccess = TodoListDataAccess;
        }

        public bool Delete(string identification, IIndividual individual)
        {
            return TodoListDataAccess.DeleteByUserName(identification, individual.UserName);
        }

        public TodoList Get(string identification, IIndividual individual)
        {
            return TodoListDataAccess.GetByUsername(identification,individual.UserName);
        }

        public IEnumerable<TodoList> GetAll(string identification, IIndividual individual)
        {
            return TodoListDataAccess.GetAllByUsername(identification,individual.UserName);
        }

        public ITodoList Set(TodoList entity, IIndividual individual)
        {
            return TodoListDataAccess.SetByUsername(entity, individual.UserName);
        }

        public ITodoList Update(TodoList entity, IIndividual individual)
        {
            return TodoListDataAccess.UpdateByUsername(entity, individual.UserName);
        }

        TodoList IEntityRepository<TodoList, IIndividual>.Set(TodoList entity, IIndividual individual)
        {
            throw new System.NotImplementedException();
        }

        TodoList IEntityRepository<TodoList, IIndividual>.Update(TodoList entity, IIndividual individual)
        {
            throw new System.NotImplementedException();
        }
    }
}
