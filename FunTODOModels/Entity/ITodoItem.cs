namespace FunTODOModels.Entity
{
    public interface ITodoItem : IEntity, IDomainModel
    {
        string Text { get; set; }
    }
}
