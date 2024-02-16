using TestingApp.Domain.Entities;

namespace TestingApp.Domain.Interfaces;

public interface ITestResultRepository
{
    Task CreateAsync(TestResult testResult);
    Task<List<TestResult>> GetAllPaginatedAsync(Guid userId, int amount, int page);
}
