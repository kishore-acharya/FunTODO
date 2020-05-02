using FunTODOModels.Entity;
using System;

namespace FunTODODataAccess.Entities
{
    public class TodoItemDataAccess : IDataAccess<TodoItem>
    {
        private IDataBase Database;

        public TodoItemDataAccess(IDataBase database)
        {
            this.Database = database;
        }

        public IDataBase DataBase { get; set; }

        public TodoItem GetByID(int iD)
        {

            return new TodoItem("not from db");
        }

        public TodoItem GetByUsername(string iD)
        {
            throw new NotImplementedException();
        }
    }
}
