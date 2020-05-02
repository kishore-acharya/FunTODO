using System.Collections.Generic;

namespace FunTODOModels.Entity
{
    public interface ITodoList:IEntity
    {
        IList<ITodoItem> TodoItemList { get; set; }
    }
}