using FunTODOModels.Entity;
using FunTODODataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunTODORepository.Entities
{
    public class TodoListRepository : IEntityListRepository<TodoList>
    {
        IDataAccess<TodoList> TodoListDataAccess;
        public TodoListRepository(IDataAccess<TodoList> TodoListDataAccess)
        {
            this.TodoListDataAccess = TodoListDataAccess;
        }

        public TodoList GetByUserID(string ID)
        {
            return TodoListDataAccess.GetByUserID(ID);
        }
    }
}
