using System.Collections.Generic;
using System.Xml;

namespace FunTODOModels.Entity
{
    public class TodoList : ITodoList<TodoItem>
    {
        private string _todoxml;
        public IList<TodoItem> TodoItemList { get; set; } = new List<TodoItem>();
        public string TODOXML
        {
            get => _todoxml;
            set
            {
                _todoxml = value;
                InitializeSelfItems(value);
            }
        }
        public string TodoTitle { get; private set; }
        private void InitializeSelfItems(string value)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(value);
            var todoItemsXpath = "todolist/todoItem";
            var todoItemsNodes = xmlDoc.SelectNodes(todoItemsXpath);
            foreach (XmlNode childrenNode in todoItemsNodes)
            {
                var todoText = childrenNode.InnerText;
                var item = new TodoItem(todoText);
                TodoItemList.Add(item);
            }
            var todoTitleXpath = "todolist/todotitle";
            var todoTitleNode = xmlDoc.SelectNodes(todoTitleXpath);
            TodoTitle = todoTitleNode.Item(0).InnerText;
        }
    }
}