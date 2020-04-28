using FunTODOModels.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunTODODataAccess.Entities
{
    public class TodoItemDataAccess : IDataAccess<TodoItem>
    {
        private IDataBase Database;

        public TodoItemDataAccess(IDataBase database)
        {
            this.Database = database;
        }

        public IDataBase DataBase { get; set ; }

        public TodoItem GetByID(int iD)
        {
            var table  = DataBase.GetDataTable(String.Format("select * from users where ID = {0}",iD));
            return new TodoItem("not from db");
        }

        public TodoItem GetByUserID(string iD)
        {
            throw new NotImplementedException();
        }
    }
}
