using FunTODOModels.Individual;
using FunTODOModels.Process;

namespace FunTODORepository.Individuals
{
    public interface IUserRepository
    {
        User GetUserByUserName(string user);
        User GetUserByUserNamePassword(LoginCredentials loginCredentials);
        bool SetUserDetails(User user);
        bool UpdateuserDetials(User user);
        bool DeleteUserDetials(User user);
    }
}
