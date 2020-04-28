using FunTODOModels.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunTODODataAccess.Entities
{
    public class TodoListDataAccess : IDataAccess<TodoList>
    {
        private readonly IDataBase dataBase;

        public TodoListDataAccess(IDataBase dataBase)
        {
            this.dataBase = dataBase;
        }

        public TodoList GetByID(int iD)
        {
            throw new NotImplementedException();
        }

        public TodoList GetByUserID(string iD)
        {
            throw new NotImplementedException();
           
        }
    }
}
