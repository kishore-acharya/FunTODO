using FunTODODataAccess.DTO;
using System.Collections.Generic;
using System.Data;

namespace FunTODODataAccess
{
    public interface IDataBase
    {
        DataTable GetDataTableFromQuery(string query);
        IEnumerable<IDataRecord> GetDataReaderFromQuery(string query);
        DataTable GetDataTableFromProcedure(StoredProcdureWithParams storedProcedureWithParams);
        IEnumerable<IDataRecord> GetDataReaderFromProcedure(StoredProcdureWithParams storedProcedureWithParams);
        void ExecuteNonQueryProcedure(StoredProcdureWithParams storedProcedureWithParams);
        bool ExecuteScalarProcedure(StoredProcdureWithParams storedProcedureWithParams);
    }
}
