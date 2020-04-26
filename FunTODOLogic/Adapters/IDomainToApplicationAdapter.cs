using FunTODOLogic;
using FunTODOModels.Entity;

namespace FunTODOLogic.Adapters
{
    public interface IDomainToApplicationAdapter<IDomainModel,IApplicationModel>:ITodoLogic
    {
        IApplicationModel ConvertToApplication(IDomainModel domain);
    }
}