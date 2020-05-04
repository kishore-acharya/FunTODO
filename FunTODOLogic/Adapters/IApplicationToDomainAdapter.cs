using FunTODOModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunTODOLogic.Adapters
{
    public interface IApplicationToDomainAdapter<IApplicationModel, IDomainModel> : IFunTodoLogic
    {
        IDomainModel ConvertToDomain(IApplicationModel application);
    }
}
