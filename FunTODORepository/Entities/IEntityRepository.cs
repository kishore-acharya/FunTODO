using System.Collections.Generic;

namespace FunTODORepository.Entities
{
    public interface IEntityRepository<IEntity>
    {
        IEnumerable<IEntity> GetAll();
        IEntity GetByUserID(string ID);
    }

}
