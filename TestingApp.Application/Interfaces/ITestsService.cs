using TestingApp.Domain.Entities;

namespace TestingApp.Application.Interfaces;

public interface ITestsService
{
    Task<List<Test>> GetAllAsync(string userId, int amount, int page);
    Task<Test> GetByIdAsync(string userId, Guid id);
    Task SubmitAsync(string userId, Guid testId, List<Guid> answersIds);
}
