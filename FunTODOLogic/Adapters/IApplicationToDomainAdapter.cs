using FunTODOModels;
using FunTODOModels.Entity;
using FunTODOLogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunTODOLogic.Adapters
{
    public interface IApplicationToDomainAdapter<IApplicationModel, IDomainModel> : ITodoLogic
    {
        IDomainModel ConvertToDomain(IApplicationModel domain);
    }
}
