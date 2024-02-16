using TestingApp.Application.DTOs.Auth;

namespace TestingApp.Application.Interfaces;

public interface IAuthService
{
    Task<string> LoginAsync(LoginDTO model);
}
