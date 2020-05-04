using FunTODOModels.Process;

namespace FunTODOLogic.Security
{
    public interface ILoginProcessor : IFunTodoLogic
    {
        bool VerifyUserByIdPassword(LoginCredentials logincredentials);
    }
}
