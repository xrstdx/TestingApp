using TestingApp.Domain.Entities;
using TestingApp.Domain.Interfaces;
using TestingApp.Infrastructure.Contexts;

namespace TestingApp.Infrastructure.Repositories;

public class TestResultRepository : ITestResultRepository
{
    private readonly TestingAppDbContext _dbContext;
    public TestResultRepository(TestingAppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task CreateAsync(TestResult testResult)
    {
        _dbContext.TestResults.Add(testResult);
        await _dbContext.SaveChangesAsync();
    }
}
