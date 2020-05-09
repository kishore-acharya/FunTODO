using System.Collections.Generic;
using System.Data.SqlClient;

namespace FunTODODataAccess.DTO
{
    public class StoredProcedureWithParams
    {
        public string procedurename { get; private set; }
        public List<SqlParameter> sqlParameterCollection { get; private set; }
        public StoredProcedureWithParams(string procedurename)
        {
            this.sqlParameterCollection = new List<SqlParameter>();
            this.procedurename = procedurename;
        }
        public void AddParam(SqlParameter sqlParameter)
        {
            this.sqlParameterCollection.Add(sqlParameter);
        }
        public void AddParamList(List<SqlParameter> sqlParameterCollection)
        {
            this.sqlParameterCollection.AddRange(sqlParameterCollection);
        }
    }
    
}
