using System.Data.SqlClient;

namespace FunTODODataAccess.DTO
{
    public class StoredProcdureWithParams
    {
        public string procedurename;
        public SqlParameterCollection sqlParameterCollection;
        public StoredProcdureWithParams()
        {
            this.sqlParameterCollection = null;
            this.procedurename = string.Empty;
        }
        public void AddParams(SqlParameter sqlParameter)
        {
            this.sqlParameterCollection.Add(sqlParameter);
        }
    }
    
}
