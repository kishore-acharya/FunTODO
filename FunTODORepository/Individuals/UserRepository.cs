using FunTODODataAccess;
using FunTODOModels.Individual;
using FunTODOModels.Process;

namespace FunTODORepository.Individuals
{
    public class UserRepository : IUserRepository
    {
        private readonly IIndividualDataAccess<User> userDataAccess;

        public UserRepository(IIndividualDataAccess<User> userDataAccess)
        {
            this.userDataAccess = userDataAccess;
        }

        public bool DeleteUserDetials(User user)
        {
            throw new System.NotImplementedException();
        }

        public User GetUserByUserName(string username)
        {
            return userDataAccess.GetByUsername(username);
        }
        public User GetUserByUserNamePassword(LoginCredentials loginCredentials)
        {
            throw new System.NotImplementedException();
        }

        public bool SetUserDetails(User user)
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateuserDetials(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}
