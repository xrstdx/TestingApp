using Microsoft.EntityFrameworkCore;
using TestingApp.Domain.Entities;
using TestingApp.Domain.Interfaces;
using TestingApp.Infrastructure.Contexts;

namespace TestingApp.Infrastructure.Repositories;

public class TestsRepository : ITestsRepository
{
    private readonly TestingAppDbContext _dbContext;

    public TestsRepository(TestingAppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<List<Test>> GetAllPaginatedAsync(Guid userId, int amount, int page)
    {
        var testIds = await _dbContext.UserTests
            .Where(ut => ut.UserId == userId)
            .Select(ut => ut.TestId)
            .ToListAsync();

        var tests = await _dbContext.Tests
            .Where(t => testIds.Contains(t.Id))
            .OrderBy(t => t.Title)
            .Skip(amount * page)
            .Take(amount)
            .ToListAsync();

        return tests;
    }
    public async Task<Test?> GetByIdAsync(Guid testId)
    {
        var test = await _dbContext.Tests
            .AsNoTracking()
            .Include(t => t.Questions)
                .ThenInclude(q => q.Options)
            .FirstOrDefaultAsync(t => t.Id == testId);

        return test;
    }
}
