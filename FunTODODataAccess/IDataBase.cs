using FunTODOModels.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunTODODataAccess
{
    public interface IDataBase
    {
        object TodoListByUserID(string iD);
    }
}
