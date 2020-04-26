using FunTODOModels.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunTODODataAccess.Entities
{
    public class TodoListDataAccess : IDataAccess<TodoList>
    {
        private IDataBase DataBase;
        public TodoListDataAccess(IDataBase database)
        {
            this.DataBase = database;  
        }

        public TodoList GetByID(int iD)
        {
            throw new NotImplementedException();
        }

        public TodoList GetByUserID(string iD)
        {
            return DataBase.TodoListByUserID(iD) as TodoList;//database should return datatable and conversion should happen here
        }
    }
}
