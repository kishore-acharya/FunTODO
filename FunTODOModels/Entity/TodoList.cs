using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunTODOModels.Entity
{
    public class TodoList : IEntityList<TodoItem>
    {
        public IList<TodoItem> Items { get;set; }
    }
}
