using FunTODOModels.Individual;
using System;

namespace FunTODODataAccess.Individuals
{
    public class UserDataAccess : IIndividualDataAccess<User>
    {

        private IDataBase Database;

        public UserDataAccess(IDataBase database)
        {
            this.Database = database;
        }

        public bool DeleteIndividualByUserName(string userName)
        {
            throw new NotImplementedException();
        }

        public User GetByID(int iD)
        {
            throw new NotImplementedException();
        }

        public User GetByUsername(string username)
        {
            throw new NotImplementedException();
        }

        public bool SetIndividualDetials(User individual)
        {
            throw new NotImplementedException();
        }

        public bool UpdateIndividualDetails(User individual)
        {
            throw new NotImplementedException();
        }

      
    }
}
