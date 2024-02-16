using Microsoft.AspNetCore.Mvc;
using TestingApp.Application.DTOs.Auth;
using TestingApp.Application.Interfaces;

namespace TestingApp.Api.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginDTO model)
    {
        string token = await _authService.LoginAsync(model);

        return Ok(token);
    }
}
