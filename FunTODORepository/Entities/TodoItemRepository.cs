﻿using FunTODODataAccess;
using FunTODOModels.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunTODORepository.Entities
{
    public class TodoItemRepository : IEntityRepository<TodoItem>
    {
        IDataAccess<TodoItem> TodoDataAccess;
        public TodoItemRepository(IDataAccess<TodoItem> TodoDataAccess)
        {
            this.TodoDataAccess = TodoDataAccess;
        }
        public IEnumerable<TodoItem> GetAll()
        {
            return new List<TodoItem>();
        }

        public TodoItem GetByUserID(string ID)
        {
            return this.TodoDataAccess.GetByUserID(ID);
        }
    }
}
