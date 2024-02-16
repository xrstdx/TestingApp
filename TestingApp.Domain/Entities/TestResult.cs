using TestingApp.Domain.Common;

namespace TestingApp.Domain.Entities;

public class TestResult : BaseEntity
{
    public int Grade { get; set; }

    public Guid TestId { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; }
    
    public ICollection<QuestionResult> QuestionResults { get; set; } = new List<QuestionResult>();
}