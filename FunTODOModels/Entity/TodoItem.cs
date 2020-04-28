namespace FunTODOModels.Entity
{
    public class TodoItem : IEntity, ITodoItem
    {
        public TodoItem(string Text)
        {
            this.Text = Text;
        }
        private string textvalue { get; set; }
        public string Text { get => this.textvalue; set => this.textvalue = value; }
    }
}
