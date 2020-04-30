namespace FunTODOLogic.Adapters
{
    public interface IDomainToApplicationAdapter<IDomainModel, IApplicationModel> : IFunTodoLogic
    {
        IApplicationModel ConvertToApplication(IDomainModel domain);
    }
}