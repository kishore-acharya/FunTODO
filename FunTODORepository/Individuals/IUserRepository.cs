using FunTODOModels.Individual;

namespace FunTODORepository.Individuals
{
    public interface IUserRepository
    {
        User GetUserByUserName(string user);
    }
}
