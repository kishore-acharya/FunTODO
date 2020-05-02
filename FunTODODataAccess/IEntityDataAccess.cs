using FunTODOModels.Entity;
using FunTODOModels.Individual;
using System.Collections.Generic;

namespace FunTODODataAccess
{
    public interface IEntityDataAccess<IEntity>
    {
        IEntity GetByUsername(string iD, FunTODOModels.Individual.IIndividual individual);
        IEntity GetByID(int iD);
        IEntity GetByUsername(string identification, string userName);
        bool DeleteByUserName(string identification, string userName);
        IEnumerable<IEntity> GetAllByUsername(string identification, string userName);
        ITodoList SetByUsername(object identification, string userName);
        ITodoList UpdateByUsername(object identification, string userName);
    }
}
