using System;
using System.Collections.Generic;
using System.Text;
using FunTODOModels.Individual;

namespace FunTODODataAccess.Individuals
{
    public class UserDataAccess : IDataAccess<User>
    {

        private IDataBase Database;

        public UserDataAccess(IDataBase database)
        {
            this.Database = database;
        }
        User IDataAccess<User>.GetByID(int iD)
        {
            throw new NotImplementedException();
        }

        User IDataAccess<User>.GetByUserID(string iD)
        {
            var table = Database.GetDataTable(String.Format("select * from users where ID = {0}", iD));
            return new User();
        }
    }
}
