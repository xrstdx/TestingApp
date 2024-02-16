using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using TestingApp.Application.Interfaces;
using TestingApp.Domain.Interfaces;
using TestingApp.Infrastructure.Contexts;
using TestingApp.Infrastructure.Repositories;
using TestingApp.Infrastructure.Services;
using TestingApp.Infrastructure.Settings;

namespace TestingApp.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddJwtAuthentication(configuration);
        services.AddTodoAppDbContext(configuration);
        services.AddRepositories();
        services.ConfigureInfrastructureSettings(configuration);

        return services;
    }

    private static IServiceCollection AddTodoAppDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<TestingAppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        return services;
    }
    private static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IUsersRepository, UsersRepository>();
        services.AddScoped<ITestsRepository, TestsRepository>();
        services.AddScoped<ITestResultRepository, TestResultRepository>();
        services.AddScoped<IOptionsRepository, OptionsRepository>();
        services.AddScoped<IJwtProvider, JwtProvider>();

        return services;
    }

    private static IServiceCollection AddJwtAuthentication(this IServiceCollection services, IConfiguration configuration)
    {


        var jwtSettings = configuration.GetSection("Jwt").Get<JwtSettings>();

        if (jwtSettings == null)
            throw new ApplicationException("JWT settings are missing in the configuration.");

        services
            .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = jwtSettings.Issuer,
                    ValidAudience = jwtSettings.Audience,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.SecretKey))
                };
            });

        return services;
    }

    private static IServiceCollection ConfigureInfrastructureSettings(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection("Jwt"));

        return services;
    }
}

