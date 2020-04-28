using System.Collections.Generic;

namespace FunTODOModels.Entity
{
    public interface IEntityList<T> : IDomainModel
    {
        IList<T> Items { get; set; }


    }
}
