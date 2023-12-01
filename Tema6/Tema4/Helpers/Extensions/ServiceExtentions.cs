using Tema4.Helpers.Seeders;
using Tema4.Repositories.ClientRepository;
using Tema4.Repositories.UserRepository;
using Tema4.Services.UserService;

namespace Tema4.Helpers.Extensions
{
    ///metodele tre sa fie statice
    public static class ServiceExtentions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services) 
        {
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IClientRepository, ClientRepository>();
            return services;
        }
        public static IServiceCollection AddServices(this IServiceCollection services) 
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IClientRepository, ClientRepository>();
            return services;
        }

        public static IServiceCollection AddSeeders(this IServiceCollection services) 
        {
            services.AddTransient<UsersSeeder>();
            return services;
        }

        
    }
}
