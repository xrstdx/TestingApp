using TestingApp.Domain.Common;

namespace TestingApp.Domain.Entities;

public class QuestionResult : BaseEntity
{
    public Guid QuestionId { get; set; }
    public Guid ChoseOptionId { get; set; }
    public Guid RightAnswerId { get; set; }

    public Guid TestResultId { get; set; }
    public TestResult TestResult { get; set; }
}
