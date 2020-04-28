using FunTODOModels.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunTODODataAccess.Entities
{
    public class TodoListDataAccess : IDataAccess<TodoList>
    {
        private readonly SqlUtil sqlUtil;

        public TodoListDataAccess()
        {
            this.sqlUtil = new SqlUtil();  
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
