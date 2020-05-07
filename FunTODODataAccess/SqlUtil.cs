using FunTODODataAccess.DTO;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace FunTODODataAccess
{
    public class SqlUtil : IDataBase
    {
        readonly string connectionString;
        public SqlUtil(IConfiguration configuration)
        {
            this.connectionString = configuration.GetConnectionString("FuntoDB");

        }
        public DataTable GetDataTableFromQuery(string query)
        {
            try
            {
                using (SqlConnection sqlconnection = new SqlConnection(this.connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, sqlconnection))
                    {
                        cmd.CommandType = CommandType.Text;
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        // this will query your database and return the result to your datatable
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        sqlconnection.Close();
                        return dataTable;
                    }
                }
            }
            catch (Exception)
            {
                return new DataTable();
            }

        }
        public IEnumerable<IDataRecord> GetDataReaderFromQuery(string query)
        {

            using (SqlConnection sqlconnection = new SqlConnection(this.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlconnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                sqlCommand.CommandType = CommandType.Text;
                sqlconnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    yield return reader;
                }
                sqlconnection.Close();
            }
            //example for accepting yield
            //string result = GetGeneralInformation(command).First()["Status"].ToString();
        }

        public DataTable GetDataTableFromProcedure(StoredProcedureWithParams storedProcedureWithParams)
        {

            try
            {
                using (SqlConnection sqlconnection = new SqlConnection(this.connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(storedProcedureWithParams.procedurename, sqlconnection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        foreach (SqlParameter parameter in storedProcedureWithParams.sqlParameterCollection)
                        {
                            cmd.Parameters.Add(parameter);
                        }
                        sqlconnection.Open();
                        DataTable dataTable = new DataTable();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        dataAdapter.Fill(dataTable);
                        sqlconnection.Close();
                        return dataTable;
                        //cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                return new DataTable();
            }

        }
        public IEnumerable<IDataRecord> GetDataReaderFromProcedure(StoredProcedureWithParams storedProcedureWithParams)
        {

            using (SqlConnection sqlconnection = new SqlConnection(this.connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(storedProcedureWithParams.procedurename, sqlconnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add(storedProcedureWithParams.sqlParameterCollection);
                    sqlconnection.Open();
                    sqlconnection.Open();
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        yield return reader;
                    }
                    sqlconnection.Close();
                }
            }

        }
        public void ExecuteNonQueryProcedure(StoredProcedureWithParams storedProcedureWithParams)
        {
            try
            {
                using (SqlConnection sqlconnection = new SqlConnection(this.connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(storedProcedureWithParams.procedurename, sqlconnection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(storedProcedureWithParams.sqlParameterCollection);
                        sqlconnection.Open();
                        cmd.ExecuteNonQuery();
                        sqlconnection.Close();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool ExecuteScalarProcedure(StoredProcedureWithParams storedProcedureWithParams)
        {
            throw new NotImplementedException();
        }
    }
}
