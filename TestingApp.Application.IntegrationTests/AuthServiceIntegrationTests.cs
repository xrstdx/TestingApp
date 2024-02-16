using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using TestingApp.Application.DTOs.Auth;
using TestingApp.Application.Interfaces;
using TestingApp.Application.Services;
using TestingApp.Domain.Entities;
using TestingApp.Domain.Interfaces;
using TestingApp.Infrastructure.Repositories;
using TestingApp.Infrastructure.Services;
using Xunit;

namespace TestingApp.IntegrationTests.Application.Services
{
    public class AuthServiceIntegrationTests
    {
        [Fact]
        public async Task LoginAsync_ValidCredentials_ReturnsToken()
        {
            // Arrange
            var serviceProvider = new ServiceCollection()
                .AddTransient<IUsersRepository, UsersRepository>() 
                .AddTransient<IJwtProvider, JwtProvider>()
                .AddTransient<IAuthService, AuthService>()
                .BuildServiceProvider();

            var authService = serviceProvider.GetRequiredService<IAuthService>();
            var loginDto = new LoginDTO("User1", "user1password");

            // Act
            var token = await authService.LoginAsync(loginDto);

            // Assert
            Assert.NotNull(token);
        }
    }
}