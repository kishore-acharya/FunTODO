namespace FunTODOModels.Entity
{
    public class TodoItem : ITodoItem
    {
        public TodoItem(string Text)
        {
            this.TextValue = Text;
        }
        private string textValue { get; set; }
        public string TextValue { get => this.textValue; set => this.textValue = value; }
    }
}
