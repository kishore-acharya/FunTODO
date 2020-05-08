using FunTODOModels.Entity;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using FunTODODataAccess.DTO;

namespace FunTODODataAccess.Entities
{
    public class TodoListDataAccess : IEntityDataAccess<TodoList>
    {
        private readonly IDataBase dataBase;

        public TodoListDataAccess(IDataBase dataBase)
        {
            this.dataBase = dataBase;
        }

        public bool DeleteByUserName(string identification, string userName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TodoList> GetAllByUsername(string userName)
        {
            var proc = new StoredProcedureWithParams("TodoListGetAll");
            proc.AddParam(new SqlParameter
            {
                Value = userName,
                ParameterName = "UserName",
                DbType = DbType.String
            });
            DataTable dt  = this.dataBase.GetDataTableFromProcedure(proc);
            IEnumerable<TodoList> todoListCollection = dt.AsEnumerable().Select(row =>
                new TodoList
                {
                    TODOXML = row["list_data"].ToString()
                });
            return todoListCollection;
        }

        public TodoList GetByID(int iD)
        {
            throw new NotImplementedException();
        }

        public TodoList GetByUsername(string identification, string userName)
        {
            throw new NotImplementedException();
        }

        public TodoList SetByUsername(object identification, string userName)
        {
            throw new NotImplementedException();
        }

        public TodoList UpdateByUsername(object identification, string userName)
        {
            throw new NotImplementedException();
        }
    }
}
