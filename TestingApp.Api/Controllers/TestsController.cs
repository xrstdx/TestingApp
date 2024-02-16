using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TestingApp.Application.DTOs.Tests;
using TestingApp.Application.Interfaces;
using TestingApp.Domain.Entities;

namespace TestingApp.Api.Controllers;

[ApiController]
[Authorize]
[Route("api/test")]
public class TestsController : ControllerBase
{
    private readonly ITestsService _testsService;

    public TestsController(ITestsService testsService)
    {
        _testsService = testsService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] int amount = 5, [FromQuery] int page = 0)
    {
        var user = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);

        var tests = await _testsService.GetAllAsync(user.Value, amount, page);

        return Ok(tests);
    }
    [HttpGet("/results")]
    public async Task<IActionResult> GetAllTestResults([FromQuery] int amount = 5, [FromQuery] int page = 0)
    {
        var user = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);

        var testResults = await _testsService.GetAllTestResultsAsync(user.Value, amount, page);

        return Ok(testResults);
    }

    [HttpGet("{id:Guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var user = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);

        var test = await _testsService.GetByIdAsync(user.Value, id);

        return Ok(test);
    }

    [HttpPost]
    public async Task<IActionResult> Sumbit(SubmitDTO submitDTO)
    {
        var user = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);

        await _testsService.SubmitAsync(user.Value, submitDTO.testId, submitDTO.answersIds);

        return Ok();
    }
}
