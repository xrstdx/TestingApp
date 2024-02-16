using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TestingApp.Domain.Entities;

namespace TestingApp.Infrastructure.EntityConfigurations;

public class TestResultEntityConfiguration : IEntityTypeConfiguration<TestResult>
{
    public void Configure(EntityTypeBuilder<TestResult> builder)
    {
        builder.ToTable("TestResults");

        builder.HasKey(tr => tr.Id);

        builder.HasMany(q => q.QuestionResults)
            .WithOne(tr => tr.TestResult)
            .HasForeignKey(tr => tr.TestResultId);
    }
}
