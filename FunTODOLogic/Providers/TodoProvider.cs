using System;
using System.Collections.Generic;
using FunTODOModels.Entity;
using FunTODOModels.Individual;
using FunTODORepository.Entities;

namespace FunTODOLogic.Providers
{
    public class TodoProvider : ITodoProvider
    {
        IEntityRepository<TodoList, IIndividual> TodoListRepository;
        public TodoProvider(IEntityRepository<TodoList,IIndividual> TodoListRepository)
        {
            this.TodoListRepository = TodoListRepository;
        }
       
        public TodoList GetTodoListForUserID(string listID, IIndividual individual)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TodoList> GetAllTodoLists(IIndividual individual)
        {
            return TodoListRepository.GetAll((individual));
        }
    }
}

