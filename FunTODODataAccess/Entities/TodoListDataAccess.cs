using FunTODOModels.Entity;
using System;
using System.Collections.Generic;

namespace FunTODODataAccess.Entities
{
    public class TodoListDataAccess : IEntityDataAccess<TodoList>
    {
        private readonly IDataBase dataBase;

        public TodoListDataAccess(IDataBase dataBase)
        {
            this.dataBase = dataBase;
        }

        public bool DeleteByUserName(string identification, string userName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TodoList> GetAllByUsername(string identification, string userName)
        {
            throw new NotImplementedException();
        }

        public TodoList GetByID(int iD)
        {
            throw new NotImplementedException();
        }

        public TodoList GetByUsername(string iD, FunTODOModels.Individual.IIndividual individual)
        {
            throw new NotImplementedException();

        }

        public TodoList GetByUsername(string identification, string userName)
        {
            throw new NotImplementedException();
        }

        public TodoList SetByUsername(object identification, string userName)
        {
            throw new NotImplementedException();
        }

        public TodoList UpdateByUsername(object identification, string userName)
        {
            throw new NotImplementedException();
        }
    }
}
