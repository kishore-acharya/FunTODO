using FunTODOModels.Entity;
using FunTODOModels.Individual;
using System.Collections.Generic;

namespace FunTODODataAccess
{
    public interface IEntityDataAccess<IEntity>
    {
        IEntity GetByID(int iD);
        IEntity GetByUsername(string identification, string userName);
        bool DeleteByUserName(string identification, string userName);
        IEnumerable<IEntity> GetAllByUsername(string userName);
        IEntity SetByUsername(object identification, string userName);
        IEntity UpdateByUsername(object identification, string userName);
    }
}
