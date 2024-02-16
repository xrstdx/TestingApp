using TestingApp.Domain.Entities;

namespace TestingApp.Application.Interfaces;

public interface IJwtProvider
{
    string GenerateToken(User user);
}

