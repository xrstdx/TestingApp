using TestingApp.Domain.Common;

namespace TestingApp.Domain.Entities;

public class Question : BaseEntity
{
    public string Text { get; set; } = string.Empty;

    public Guid TestId { get; set; }
    public Test Test { get; set; }
    public ICollection<Option> Options { get; set; } = new List<Option>();
}
