using System.Collections.Generic;
using System.Data;

namespace FunTODODataAccess
{
    public interface IDataBase
    {
        DataTable GetDataTable(string command);

        IEnumerable<IDataRecord> GetDataReader(string command);

    }
}
