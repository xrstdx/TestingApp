using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TestingApp.Domain.Entities;

namespace TestingApp.Infrastructure.Contexts;

public class TestingAppDbContext : DbContext
{
    public TestingAppDbContext(DbContextOptions<TestingAppDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Test> Tests { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<Option> Options { get; set; }
    public DbSet<TestResult> TestResults { get; set; }
    public DbSet<QuestionResult> QuestionResults { get; set; }
    public DbSet<UserTest> UserTests { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
