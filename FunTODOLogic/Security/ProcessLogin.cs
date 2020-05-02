using FunTODOModels.Process;

namespace FunTODOLogic.Security
{
    public class ProcessLogin : ILoginProcessor
    {
        public ProcessLogin()
        {

        }
        public bool VerifyUserByIdPassword(LoginCredentials logincredentials)
        {
            //TODO:actual
            return true;
        }
    }
}
