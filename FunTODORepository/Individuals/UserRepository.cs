using FunTODODataAccess;
using FunTODOModels.Individual;

namespace FunTODORepository.Individuals
{
    public class UserRepository : IUserRepository
    {
        private readonly IDataAccess<User> userDataAccess;

        public UserRepository(IDataAccess<User> userDataAccess)
        {
            this.userDataAccess = userDataAccess;
        }

        public User GetUserByUserName(string username)
        {
            return userDataAccess.GetByUserID(username);
        }
    }
}
