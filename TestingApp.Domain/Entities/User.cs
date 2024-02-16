using TestingApp.Domain.Common;

namespace TestingApp.Domain.Entities;

public class User : BaseEntity
{
    public string UserName { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;

    public ICollection<Test> Tests { get; set; } = new List<Test>();
    public ICollection<TestResult> TestResults { get; set; } = new List<TestResult>();
}
