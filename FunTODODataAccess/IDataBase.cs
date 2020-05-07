using FunTODODataAccess.DTO;
using System.Collections.Generic;
using System.Data;

namespace FunTODODataAccess
{
    public interface IDataBase
    {
        DataTable GetDataTableFromQuery(string query);
        IEnumerable<IDataRecord> GetDataReaderFromQuery(string query);
        DataTable GetDataTableFromProcedure(StoredProcedureWithParams storedProcedureWithParams);
        IEnumerable<IDataRecord> GetDataReaderFromProcedure(StoredProcedureWithParams storedProcedureWithParams);
        void ExecuteNonQueryProcedure(StoredProcedureWithParams storedProcedureWithParams);
        bool ExecuteScalarProcedure(StoredProcedureWithParams storedProcedureWithParams);
    }
}
