using FunTODOModels.Entity;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace FunTODODataAccess
{
    public class FuntodoDataBase : SqlUtil, IDataBase
    {

        public IConfiguration configuration { get; set; }
        public FuntodoDataBase(IConfiguration configuration) : base(configuration)
        {


        }
        object TodoListByUserID(string iD)
        {
            var todoListfromDB = new TodoList();
            todoListfromDB.Items = new List<TodoItem>();
            todoListfromDB.Items.Add(new TodoItem("ItemA"));
            todoListfromDB.Items.Add(new TodoItem("ItemB"));
            todoListfromDB.Items.Add(new TodoItem("ItemC"));
            todoListfromDB.Items.Add(new TodoItem("ItemD"));
            return todoListfromDB;
        }
    }
}
