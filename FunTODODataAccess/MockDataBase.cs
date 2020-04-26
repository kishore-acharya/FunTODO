using FunTODOModels.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunTODODataAccess
{
    public class MockDataBase : IDataBase
    {
       
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
