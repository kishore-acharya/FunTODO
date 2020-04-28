using System;
using FunTODOCommon;
using FunTODODataAccess;
using FunTODODataAccess.Entities;
using FunTODODataAccess.Individuals;
using FunTODOLogic;
using FunTODOLogic.Adapters;
using FunTODOLogic.Providers;
using FunTODOLogic.Security;
using FunTODOModels;
using FunTODOModels.Entity;
using FunTODOModels.Individual;
using FunTODORepository;
using FunTODORepository.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace FunTODOCommon
{
    public  class FunTodoDependencyService
    {

        public static void ConfigureDependencies(IServiceCollection services)
        {
            //Buisness Logic
            services.AddSingleton<ITodoProvider, TodoProvider>();
            //Repository
            services.AddSingleton<IEntityListRepository<TodoList>,TodoListRepository>();
            services.AddSingleton<IEntityRepository<TodoItem>, TodoItemRepository>();
            //security
            services.AddScoped<ILogin, ProcessLogin>();
            //Data Access
            services.AddSingleton<IDataAccess<TodoList>, TodoListDataAccess>();
            services.AddSingleton<IDataAccess<TodoItem>, TodoItemDataAccess>();
            services.AddSingleton<IDataAccess<User>, UserDataAccess>();
            services.AddSingleton<IDataBase, FuntodoDataBase>();

        }
    }
}
