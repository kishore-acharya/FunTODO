using FunTODOModels.Entity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace FunTODODataAccess
{
    public class MockDataBase : SqlUtil, IDataBase
    {

        public IConfiguration configuration { get; set; }
        public MockDataBase(IConfiguration configuration):base(configuration)
        {

            var k = new FuntodoDataBase(configuration);
        }
        object IDataBase.TodoListByUserID(string iD)
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
