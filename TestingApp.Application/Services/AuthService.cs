using TestingApp.Application.DTOs.Auth;
using TestingApp.Application.Helpers;
using TestingApp.Application.Interfaces;
using TestingApp.Domain.Exceptions;
using TestingApp.Domain.Interfaces;

namespace TestingApp.Application.Services;

public class AuthService : IAuthService
{
    private readonly IUsersRepository _usersRepository;
    private readonly IJwtProvider _jwtProvider;

    public AuthService(IUsersRepository usersRepository, IJwtProvider jwtProvider)
    {
        _usersRepository = usersRepository;
        _jwtProvider = jwtProvider;
    }

    public async Task<string> LoginAsync(LoginDTO model)
    {
        var user = await _usersRepository.GetUserByUserNameAsync(model.UserName);

        if (user is null || user.PasswordHash != PasswordHelper.HashPassword(model.Password))
            throw new IncorrectCredentialsException();

        string token = _jwtProvider.GenerateToken(user);

        return token;
    }
}
