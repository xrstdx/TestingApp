using TestingApp.Domain.Entities;

namespace TestingApp.Domain.Interfaces;

public interface ITestsRepository
{
    Task<List<Test>> GetAllPaginatedAsync(Guid userId, int amount, int page);
    Task<Test?> GetByIdAsync(Guid testId);
}
