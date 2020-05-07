using System.Collections.Generic;

namespace FunTODOModels.Entity
{
    public class TodoList : ITodoList<TodoItem>
    {
        private IList<TodoItem> todoItemList;
        public IList<TodoItem> TodoItemList { get => this.todoItemList; set =>this.todoItemList=value; }
        public string TODOXML;
    }
}
