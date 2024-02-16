using TestingApp.Domain.Common;

namespace TestingApp.Domain.Entities;

public class Option : BaseEntity
{
    public string Text { get; set; } = string.Empty;
    public bool IsCorrect { get; set; }

    public Guid QuestionId { get; set; }
    public Question Question { get; set; }
}
