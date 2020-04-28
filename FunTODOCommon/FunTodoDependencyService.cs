using System;
using FunTODOCommon;
using FunTODODataAccess;
using FunTODODataAccess.Entities;
using FunTODOLogic;
using FunTODOLogic.Adapters;
using FunTODOLogic.Providers;
using FunTODOLogic.Security;
using FunTODOModels;
using FunTODOModels.Entity;
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
            services.AddSingleton<IEntityListRepository<TodoList>,TodoListRepository>();
            services.AddSingleton<IEntityRepository<TodoItem>, TodoItemRepository>();
            services.AddSingleton<ILogin, ProcessLogin>();
            //Data Access
            services.AddSingleton<IDataAccess<TodoList>, TodoListDataAccess>();
            services.AddSingleton<IDataAccess<TodoItem>, TodoItemDataAccess>();
            services.AddSingleton<IDataBase, FuntodoDataBase>();
            


        }
    }
}
