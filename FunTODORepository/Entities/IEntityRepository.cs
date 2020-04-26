using FunTODOModels.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunTODORepository.Entities
{
    public interface IEntityRepository<IEntity>
    {
        IEnumerable<IEntity> GetAll();
        IEntity GetByUserID(string ID);
    }

}
