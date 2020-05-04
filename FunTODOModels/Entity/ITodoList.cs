using System.Collections.Generic;

namespace FunTODOModels.Entity
{
    public interface ITodoList<T>:IEntity
    {
        IList<T> TodoItemList { get; set; }
    }
}