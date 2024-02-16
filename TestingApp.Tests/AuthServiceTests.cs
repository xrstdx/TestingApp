using Moq;
using System.Threading.Tasks;
using TestingApp.Application.DTOs.Auth;
using TestingApp.Application.Helpers;
using TestingApp.Application.Interfaces;
using TestingApp.Application.Services;
using TestingApp.Domain.Entities;
using TestingApp.Domain.Exceptions;
using TestingApp.Domain.Interfaces;
using Xunit;

namespace TestingApp.UnitTests.Application.Services
{
    public class AuthServiceTests
    {
        [Fact]
        public async Task LoginAsync_ValidCredentials_ReturnsToken()
        {
            // Arrange
            var userName = "testuser";
            var password = "testpassword";
            var hashedPassword = PasswordHelper.HashPassword(password); 
            var user = new User { UserName = userName, PasswordHash = hashedPassword };
            var loginDto = new LoginDTO(userName, password);

            var usersRepositoryMock = new Mock<IUsersRepository>();
            usersRepositoryMock.Setup(repo => repo.GetUserByUserNameAsync(userName)).ReturnsAsync(user);

            var jwtProviderMock = new Mock<IJwtProvider>();
            jwtProviderMock.Setup(provider => provider.GenerateToken(user)).Returns("testtoken");

            var authService = new AuthService(usersRepositoryMock.Object, jwtProviderMock.Object);

            // Act
            var token = await authService.LoginAsync(loginDto);

            // Assert
            Assert.NotNull(token);
        }

        [Fact]
        public async Task LoginAsync_InvalidCredentials_ThrowsIncorrectCredentialsException()
        {
            // Arrange
            var userName = "testuser";
            var password = "testpassword";
            var user = new User { UserName = userName, PasswordHash = PasswordHelper.HashPassword("correctpassword") }; 

            var loginDto = new LoginDTO(userName, password);

            var usersRepositoryMock = new Mock<IUsersRepository>();
            usersRepositoryMock.Setup(repo => repo.GetUserByUserNameAsync(userName)).ReturnsAsync(user);

            var authService = new AuthService(usersRepositoryMock.Object, null);

            // Act & Assert
            await Assert.ThrowsAsync<IncorrectCredentialsException>(() => authService.LoginAsync(loginDto));
        }
    }
}
