using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace FunTODODataAccess
{
    public class SqlUtil
    {
        string connectionString;
        protected SqlUtil(IConfiguration configuration)
        {
            this.connectionString = configuration.GetConnectionString("FuntoDB");

        }
        public DataTable GetDataTable(string command)
        {
            try
            {
                using (SqlConnection sqlconnection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand(command, sqlconnection);
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    // this will query your database and return the result to your datatable
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    sqlconnection.Close();
                    return dataTable;

                }
            }
            catch
            {
                return new DataTable();
            }

        }
        public IEnumerable<IDataRecord> GetDataReader(string command)
        {

            using (SqlConnection sqlconnection = new SqlConnection(this.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(command, sqlconnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                sqlCommand.CommandType = CommandType.Text;
                sqlconnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    yield return reader;
                }
            }
            //example for accepting yield
            //string result = GetGeneralInformation(RecID).First()["Status"].ToString();
        }




        //public User GetUserByUserName()
        //{
        //    using (SqlConnection con = new SqlConnection(this.connectionString))
        //    {
        //        SqlCommand cmd = new SqlCommand("SELECT * FROM UserMaster", con);
        //        cmd.CommandType = CommandType.Text;
        //        con.Open();
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        // this will query your database and return the result to your datatable
        //        da.Fill(dataTable);
        //        //while (sqlDataReader.Read())
        //        //{
        //        //    var user = new User();

        //        //    user.ID = Convert.ToInt32(sqlDataReader["ID"]);
        //        //    user.UserID = sqlDataReader["username"].ToString();
        //        //    user.FirstName = sqlDataReader["firstname"].ToString();
        //        //}

        //    }
        //}

    }
}
