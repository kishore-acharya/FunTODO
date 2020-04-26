using System;
using System.Collections.Generic;
using System.Text;
using FunTODOModels.Entity;

namespace FunTODODataAccess
{
    public interface IDataAccess<T>
    {
        T GetByUserID(string iD);
        T GetByID(int iD);
    }
}
