using TestingApp.Application.Interfaces;
using TestingApp.Domain.Entities;
using TestingApp.Domain.Exceptions;
using TestingApp.Domain.Interfaces;

namespace TestingApp.Application.Services;

public class TestsService : ITestsService
{
    private readonly IUsersRepository _usersRepository;
    private readonly ITestsRepository _testsRepository;
    private readonly IOptionsRepository _optionsRepository;
    private readonly ITestResultRepository _testResultRepository;

    public TestsService(IUsersRepository usersRepository, ITestsRepository testsRepository, IOptionsRepository optionsRepository, ITestResultRepository testResultRepository)
    {
        _usersRepository = usersRepository;
        _testsRepository = testsRepository;
        _optionsRepository = optionsRepository;
        _testResultRepository = testResultRepository;
    }

    public async Task<List<Test>> GetAllAsync(string userId, int amount, int page)
    {
        if (string.IsNullOrEmpty(userId))
            throw new AccessForbiddenException();

        var parsedUserId = Guid.Parse(userId!);

        if (!await _usersRepository.UserExistsById(parsedUserId))
            throw new AccessForbiddenException();

        var tests = await _testsRepository.GetAllPaginatedAsync(parsedUserId, amount, page);

        return tests;
    }

    public async Task<List<TestResult>> GetAllTestResultsAsync(string userId, int amount, int page)
    {
        if (string.IsNullOrEmpty(userId))
            throw new AccessForbiddenException();

        var parsedUserId = Guid.Parse(userId!);

        if (!await _usersRepository.UserExistsById(parsedUserId))
            throw new AccessForbiddenException();

        var testResults = await _testResultRepository.GetAllPaginatedAsync(parsedUserId, amount, page);

        return testResults;
    }

    public async Task<Test> GetByIdAsync(string userId, Guid id)
    {
        if (string.IsNullOrEmpty(userId))
            throw new AccessForbiddenException();

        var parsedUserId = Guid.Parse(userId!);

        if (!await _usersRepository.UserExistsById(parsedUserId))
            throw new AccessForbiddenException();

        var test = await _testsRepository.GetByIdAsync(id);

        return test;
    }

    public async Task SubmitAsync(string userId, Guid testId, List<Guid> answersIds)
    {
        if (string.IsNullOrEmpty(userId))
            throw new AccessForbiddenException();

        var parsedUserId = Guid.Parse(userId!);

        if (!await _usersRepository.UserExistsById(parsedUserId))
            throw new AccessForbiddenException();

        int grade = 0;

        foreach(var aId in answersIds)
            if(await _optionsRepository.IsOptionRight(aId))
                grade++;

        var testResult = new TestResult
        {
            Id = Guid.NewGuid(),
            UserId = parsedUserId,
            TestId = testId,
            Grade = grade
        };

        await _testResultRepository.CreateAsync(testResult);      
    }
}
