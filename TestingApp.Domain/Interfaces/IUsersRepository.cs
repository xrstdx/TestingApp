using TestingApp.Domain.Entities;

namespace TestingApp.Domain.Interfaces;

public interface IUsersRepository
{
    Task CreateUserAsync(User user);
    Task<User?> GetUserByUserNameAsync(string email);
    Task<bool> UserExistsByUserName(string email);
    Task<User?> GetUserByIdAsync(Guid id);
    Task<bool> UserExistsById(Guid id);
}
