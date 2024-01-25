using backend.Helpers.Seeders;
using backend.Repositories.AutorRepository;
using backend.Repositories.CarteAutorRepository;
using backend.Repositories.CarteRepository;
using backend.Repositories.EdituraRepository;
using backend.Repositories.TestRepository;
using backend.Services.AutorService;
using backend.Services.CarteAutorService;
using backend.Services.CarteService;
using backend.Services.EdituraService;
using backend.Services.TestService;

namespace backend.Helpers.Extensions;

public static class ServiceExtensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddTransient<ITestRepository, TestRepository>();


        services.AddTransient<IAutorRepository, AutorRepository>();
        services.AddTransient<IEdituraRepository, EdituraRepository>();
        services.AddTransient<ICarteRepository, CarteRepository>();
        services.AddTransient<ICarteAutorRepository, CarteAutorRepository>();
        return services;
    }

    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddTransient<ITestService, TestService>();


        services.AddTransient<IAutorService, AutorService>();
        services.AddTransient<IEdituraService, EdituraService>();
        services.AddTransient<ICarteService, CarteService>();
        services.AddTransient<ICarteAutorService, CarteAutorSerivce>();

        return services;
    }

    public static IServiceCollection AddSeeders(this IServiceCollection services)
    {
        services.AddTransient<TestSeeder>();
    
        return services;
    }
}