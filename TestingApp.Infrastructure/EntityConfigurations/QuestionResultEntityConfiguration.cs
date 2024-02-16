using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestingApp.Domain.Entities;

namespace TestingApp.Infrastructure.EntityConfigurations;

public class QuestionResultEntityConfiguration : IEntityTypeConfiguration<QuestionResult>
{
    public void Configure(EntityTypeBuilder<QuestionResult> builder)
    {
        builder.ToTable("QuestionResults");

        builder.HasKey(q => q.Id);
    }
}
