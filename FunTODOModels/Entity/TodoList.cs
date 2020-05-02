using System.Collections.Generic;

namespace FunTODOModels.Entity
{
    public class TodoList : ITodoList
    {
        private IList<ITodoItem> todoItemList;
        public IList<ITodoItem> TodoItemList { get => this.todoItemList; set =>this.todoItemList=value; }
    }
}
