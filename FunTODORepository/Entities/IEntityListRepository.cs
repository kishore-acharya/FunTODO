using FunTODOModels.Entity;
using System.Collections.Generic;

namespace FunTODORepository.Entities
{
    public interface IEntityListRepository<IEntityList>
    {
        IEntityList GetByUserID(string ID);
    }
}