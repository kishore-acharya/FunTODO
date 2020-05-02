using FunTODODataAccess.DTO;
using System.Collections.Generic;
using System.Data;

namespace FunTODODataAccess
{
    public interface IDataBase
    {
        DataTable GetDataTableFromQuery(string query);
        IEnumerable<IDataRecord> GetDataReaderFromQuery(string query);
        DataTable GetDataTableFromProcedure(StoredProcdureWithParams storedProcdureWithParams);
        IEnumerable<IDataRecord> GetDataReaderFromProcedure(StoredProcdureWithParams storedProcdureWithParams);
        void ExecureNonQueryProcedure(StoredProcdureWithParams storedProcdureWithParams);
    }
}
