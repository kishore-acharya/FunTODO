using System.Collections.Generic;

namespace FunTODOModels.Entity
{
    public class TodoList : IEntityList<TodoItem>
    {
        public IList<TodoItem> Items { get; set; }
    }
}
