using FunTODOModels.Individual;
using System;

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
            const string quote = "\"";
            var table = Database.GetDataTable("select * from UserMaster where username ='" + iD + "'");
            return new User() {
                ID = Int32.Parse(table.Rows[0]["ID"].ToString()),
                UserID = table.Rows[0]["username"].ToString(),
                FirstName= table.Rows[0]["firstname"].ToString(),
                LastName= table.Rows[0]["lastname"].ToString(),
                Password = table.Rows[0]["password"].ToString()

            };
        }
    }
}
