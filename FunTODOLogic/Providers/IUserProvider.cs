using FunTODOModels.Individual;

namespace FunTODOLogic.Providers
{
    public interface IUserProvider
    {
        User GetUserByUserName(string username);
    }
}
