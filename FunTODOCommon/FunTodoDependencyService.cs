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
            services.AddSingleton<IEntityListRepository<TodoList>, TodoListRepository>();
            services.AddSingleton<IEntityRepository<TodoItem>, TodoItemRepository>();
            services.AddSingleton<IUserRepository, UserRepository>();
            //security
            services.AddSingleton<ILoginProcessor, ProcessLogin>();
            //Data Access
            services.AddSingleton<IDataAccess<TodoList>, TodoListDataAccess>();
            services.AddSingleton<IDataAccess<TodoItem>, TodoItemDataAccess>();
            services.AddSingleton<IDataAccess<User>, UserDataAccess>();
            services.AddSingleton<IDataBase, FuntodoDataBase>();

        }
    }
}
