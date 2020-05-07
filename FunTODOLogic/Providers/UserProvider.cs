using FunTODOModels.Individual;
using FunTODORepository.Individuals;

namespace FunTODOLogic.Providers
{
    public class UserProvider : IUserProvider
    {
        private IUserRepository userRepository;

        public UserProvider(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public User GetUserByUserName(string username)
        {
            return new User()
            {
                UserName = "kishore101"
            };
            //return userRepository.GetUserByUserName(username);//TODO:actual implementaion
        }
    }
}
