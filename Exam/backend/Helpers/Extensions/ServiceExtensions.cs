using backend.Helpers.Seeders;
using backend.Repositories.TestRepository;
using backend.Services.TestService;

namespace backend.Helpers.Extensions;

public static class ServiceExtensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddTransient<ITestRepository, TestRepository>();

        return services;
    }

    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddTransient<ITestService, TestService>();
        
        return services;
    }

    public static IServiceCollection AddSeeders(this IServiceCollection services)
    {
        services.AddTransient<TestSeeder>();
    
        return services;
    }
}