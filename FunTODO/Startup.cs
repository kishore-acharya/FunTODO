using FunTODOCommon;
using FunTODOLogic.Adapters;
using FunTODOModels.Entity;
using FunTODOModels.Process;
using FunTODOWebSite.Adapters;
using FunTODOWebSite.Models.Entity;
using FunTODOWebSite.Models.Login;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FunTODO
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();//default cookie based authentication of core mvc
            //Register Website Only Dependencies
            services.AddSingleton<IDomainToApplicationAdapter<TodoList, TodoListViewModel>, TodoListAdapter>();
            services.AddSingleton<IApplicationToDomainAdapter<LoginModel, LoginCredentials>,LoginAdapter>();
            //Register Common Dependencies
            FunTodoDependencyService.ConfigureDependencies(services);
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            //var cookiePolicyOptions = new CookiePolicyOptions//default is lax , this is to set to something else
            //{
            //    MinimumSameSitePolicy = SameSiteMode.Strict,
            //};
            //app.UseCookiePolicy(cookiePolicyOptions);
            app.UseCookiePolicy();//the default policy is lax
            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
