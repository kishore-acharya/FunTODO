using FunTODODataAccess;
using FunTODODataAccess.Entities;
using FunTODODataAccess.Individuals;
using FunTODOLogic.Providers;
using FunTODOLogic.Security;
using FunTODOModels.Entity;
using FunTODOModels.Individual;
using FunTODORepository.Entities;
using FunTODORepository.Individuals;
using Microsoft.Extensions.DependencyInjection;

namespace FunTODOCommon
{
    public class FunTodoDependencyService
    {

        public static void ConfigureDependencies(IServiceCollection services)
        {
            //Buisness Logic
            services.AddSingleton<ITodoProvider, TodoProvider>();
            services.AddSingleton<IUserProvider, UserProvider>();
            //Repository
            services.AddSingleton<IEntityRepository<TodoList, IIndividual>, TodoListRepository>();
            services.AddSingleton<IUserRepository, UserRepository>();
            //security
            services.AddSingleton<ILoginProcessor, ProcessLogin>();
            //Data Access
            services.AddSingleton<IEntityDataAccess<TodoList>, TodoListDataAccess>();
            services.AddSingleton<IIndividualDataAccess<User>, UserDataAccess>();
            services.AddSingleton<IDataBase, SqlUtil>();

        }
    }
}
