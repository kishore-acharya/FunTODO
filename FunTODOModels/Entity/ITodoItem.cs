using System;
using System.Collections.Generic;
using System.Text;

namespace FunTODOModels.Entity
{
    public interface ITodoItem : IEntity, IDomainModel
    {
        string Text { get; set; }
    }
}
