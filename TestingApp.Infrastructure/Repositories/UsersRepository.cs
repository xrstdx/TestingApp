using Microsoft.EntityFrameworkCore;
using TestingApp.Domain.Entities;
using TestingApp.Domain.Interfaces;
using TestingApp.Infrastructure.Contexts;

namespace TestingApp.Infrastructure.Repositories;

public class UsersRepository : IUsersRepository
{
    private readonly TestingAppDbContext _dbContext;

    public UsersRepository(TestingAppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task CreateUserAsync(User user)
    {
        _dbContext.Users.Add(user);

        await _dbContext.SaveChangesAsync();
    }

    public async Task<User?> GetUserByUserNameAsync(string userName)
    {
        var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.UserName == userName);

        return user;
    }

    public async Task<User?> GetUserByIdAsync(Guid id)
    {
        var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == id);

        return user;
    }

    public async Task<bool> UserExistsByUserName(string userName)
    {
        var emailExists = await _dbContext.Users.AnyAsync(u => u.UserName == userName);

        return emailExists;
    }

    public async Task<bool> UserExistsById(Guid id)
    {
        var idExists = await _dbContext.Users.AnyAsync(u => u.Id == id);

        return idExists;
    }
}
