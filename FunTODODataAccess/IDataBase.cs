using FunTODOModels.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace FunTODODataAccess
{
    public interface IDataBase
    {
        DataTable GetDataTable(string command);
       
        IEnumerable<IDataRecord> GetDataReader(string command);
        
    }
}
