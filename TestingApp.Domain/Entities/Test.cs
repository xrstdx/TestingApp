using TestingApp.Domain.Common;

namespace TestingApp.Domain.Entities;

public class Test : BaseEntity
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public ICollection<Question> Questions { get; set; } = new List<Question>();
    public ICollection<User> Users { get; set; } = new List<User>();
}