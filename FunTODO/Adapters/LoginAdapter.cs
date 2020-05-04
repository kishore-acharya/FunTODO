using FunTODOLogic.Adapters;
using FunTODOModels.Process;
using FunTODOWebSite.Models.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunTODOWebSite.Adapters
{
    public class LoginAdapter : IApplicationToDomainAdapter<LoginModel, LoginCredentials>
    {
        public LoginCredentials ConvertToDomain(LoginModel application)
        {
            return new LoginCredentials()
            {
                username = application.UserName,
                password = application.Password
            };
        }
    }
}
