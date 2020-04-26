using System;
using System.Collections.Generic;
using System.Text;

namespace FunTODOModels.Entity
{
    public interface IEntityList<T>:IDomainModel
    {
        IList<T> Items { get; set; }


    }
}
