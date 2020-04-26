using FunTODOModels.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunTODOLogic.Providers
{
    public interface ITodoProvider:ITodoLogic
    {
        TodoList GetTodoListForUserID(string UserID);
    }
}
