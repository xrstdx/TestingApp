using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestingApp.Application.Services;
using TestingApp.Domain.Entities;
using TestingApp.Domain.Exceptions;
using TestingApp.Domain.Interfaces;
using Xunit;

namespace TestingApp.UnitTests.Application.Services
{
    public class TestsServiceTests
    {
        [Fact]
        public async Task GetAllAsync_ValidUserId_ReturnsTests()
        {
            // Arrange
            var userId = Guid.NewGuid().ToString();
            var usersRepositoryMock = new Mock<IUsersRepository>();
            usersRepositoryMock.Setup(repo => repo.UserExistsById(It.IsAny<Guid>())).ReturnsAsync(true);
            var tests = new List<Test>(); 
            var testsRepositoryMock = new Mock<ITestsRepository>();
            testsRepositoryMock.Setup(repo => repo.GetAllPaginatedAsync(It.IsAny<Guid>(), It.IsAny<int>(), It.IsAny<int>())).ReturnsAsync(tests);
            var service = new TestsService(usersRepositoryMock.Object, testsRepositoryMock.Object, null, null);

            // Act
            var result = await service.GetAllAsync(userId, 10, 1);

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetAllAsync_InvalidUserId_ThrowsAccessForbiddenException()
        {
            // Arrange
            var userId = Guid.NewGuid().ToString();
            var usersRepositoryMock = new Mock<IUsersRepository>();
            usersRepositoryMock.Setup(repo => repo.UserExistsById(It.IsAny<Guid>())).ReturnsAsync(false);
            var service = new TestsService(usersRepositoryMock.Object, null, null, null);

            // Act & Assert
            await Assert.ThrowsAsync<AccessForbiddenException>(() => service.GetAllAsync(userId, 10, 1));
        }

        [Fact]
        public async Task GetByIdAsync_ValidUserId_ReturnsTest()
        {
            // Arrange
            var userId = Guid.NewGuid().ToString();
            var testId = Guid.NewGuid();
            var usersRepositoryMock = new Mock<IUsersRepository>();
            usersRepositoryMock.Setup(repo => repo.UserExistsById(It.IsAny<Guid>())).ReturnsAsync(true);
            var test = new Test(); 
            var testsRepositoryMock = new Mock<ITestsRepository>();
            testsRepositoryMock.Setup(repo => repo.GetByIdAsync(It.IsAny<Guid>())).ReturnsAsync(test);
            var service = new TestsService(usersRepositoryMock.Object, testsRepositoryMock.Object, null, null);

            // Act
            var result = await service.GetByIdAsync(userId, testId);

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetByIdAsync_InvalidUserId_ThrowsAccessForbiddenException()
        {
            // Arrange
            var userId = Guid.NewGuid().ToString();
            var testId = Guid.NewGuid();
            var usersRepositoryMock = new Mock<IUsersRepository>();
            usersRepositoryMock.Setup(repo => repo.UserExistsById(It.IsAny<Guid>())).ReturnsAsync(false);
            var service = new TestsService(usersRepositoryMock.Object, null, null, null);

            // Act & Assert
            await Assert.ThrowsAsync<AccessForbiddenException>(() => service.GetByIdAsync(userId, testId));
        }

        [Fact]
        public async Task SubmitAsync_ValidData_CreatesTestResult()
        {
            // Arrange
            var userId = Guid.NewGuid().ToString();
            var testId = Guid.NewGuid();
            var answersIds = new List<Guid> { Guid.NewGuid(), Guid.NewGuid() }; // Provide answer IDs
            var usersRepositoryMock = new Mock<IUsersRepository>();
            usersRepositoryMock.Setup(repo => repo.UserExistsById(It.IsAny<Guid>())).ReturnsAsync(true);
            var optionsRepositoryMock = new Mock<IOptionsRepository>();
            optionsRepositoryMock.Setup(repo => repo.IsOptionRight(It.IsAny<Guid>())).ReturnsAsync(true);
            var testResultRepositoryMock = new Mock<ITestResultRepository>();
            var service = new TestsService(usersRepositoryMock.Object, null, optionsRepositoryMock.Object, testResultRepositoryMock.Object);

            // Act
            await service.SubmitAsync(userId, testId, answersIds);

            // Assert
            testResultRepositoryMock.Verify(repo => repo.CreateAsync(It.IsAny<TestResult>()), Times.Once);
        }

        [Fact]
        public async Task SubmitAsync_InvalidUserId_ThrowsAccessForbiddenException()
        {
            // Arrange
            var userId = Guid.NewGuid().ToString();
            var testId = Guid.NewGuid();
            var answersIds = new List<Guid>(); // Provide answer IDs
            var usersRepositoryMock = new Mock<IUsersRepository>();
            usersRepositoryMock.Setup(repo => repo.UserExistsById(It.IsAny<Guid>())).ReturnsAsync(false);
            var service = new TestsService(usersRepositoryMock.Object, null, null, null);

            // Act & Assert
            await Assert.ThrowsAsync<AccessForbiddenException>(() => service.SubmitAsync(userId, testId, answersIds));
        }
    }
}
