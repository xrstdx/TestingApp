using Microsoft.EntityFrameworkCore;
using TestingApp.Domain.Interfaces;
using TestingApp.Infrastructure.Contexts;

namespace TestingApp.Infrastructure.Repositories;

public class OptionsRepository : IOptionsRepository
{
    private readonly TestingAppDbContext _dbContext;
    public OptionsRepository(TestingAppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<bool> IsOptionRight(Guid id)
    {
        var option = await _dbContext.Options.FirstOrDefaultAsync(o => o.Id == id);

        return option.IsCorrect;
    }
}
