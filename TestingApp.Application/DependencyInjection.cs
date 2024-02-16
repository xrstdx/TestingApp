using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TestingApp.Application.Interfaces;
using TestingApp.Application.Services;

namespace TestingApp.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddServices();

        return services;
    }

    private static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<ITestsService, TestsService>();

        return services;
    }
}