using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TestingApp.Domain.Entities;

namespace TestingApp.Infrastructure.EntityConfigurations;

public class QuestionEntityConfiguration : IEntityTypeConfiguration<Question>
{
    public void Configure(EntityTypeBuilder<Question> builder)
    {
        builder.ToTable("Questions");

        builder.HasKey(q => q.Id);

        builder.HasData(
            new Question { Id = Guid.Parse("5a4316d8-d0b3-4e59-aab7-f61618a84249"), Text = "What is encapsulation?", TestId = Guid.Parse("c365b577-aa53-4027-962e-7a0854c5f0ea") },
            new Question { Id = Guid.Parse("94ca6708-6e25-4223-89fd-4d5dab7d1032"), Text = "What is inheritance?", TestId = Guid.Parse("c365b577-aa53-4027-962e-7a0854c5f0ea") },
            new Question { Id = Guid.Parse("dc7a3076-5904-4b38-b412-87095750f67f"), Text = "What is polymorphism?", TestId = Guid.Parse("c365b577-aa53-4027-962e-7a0854c5f0ea") },

            new Question { Id = Guid.Parse("b5df5f8d-2e06-448e-87f8-92358be52299"), Text = "What is C#?", TestId = Guid.Parse("83c697b7-35a5-494d-a221-e1483371d597") },
            new Question { Id = Guid.Parse("d6099063-78e9-4f76-bd18-67e988b298e5"), Text = "What is the .NET Framework?", TestId = Guid.Parse("83c697b7-35a5-494d-a221-e1483371d597") },
            new Question { Id = Guid.Parse("cf1559f6-01c3-435e-bc80-dd14f69794bf"), Text = "What is ASP.NET Core?", TestId = Guid.Parse("83c697b7-35a5-494d-a221-e1483371d597") },

            new Question { Id = Guid.Parse("667bc105-73d3-4a00-b09d-e66787b2d7ad"), Text = "What is SQL?", TestId = Guid.Parse("3f8d19c8-4627-4212-8900-70e3f0052f9f") },
            new Question { Id = Guid.Parse("d7cc7885-fc2e-4f51-a7f7-f05b0bf7dd7b"), Text = "What is a primary key in a database?", TestId = Guid.Parse("3f8d19c8-4627-4212-8900-70e3f0052f9f") },
            new Question { Id = Guid.Parse("2b71aeb6-586d-4f9e-bced-6c0ead8aa64e"), Text = "What is the difference between SQL and NoSQL databases?", TestId = Guid.Parse("3f8d19c8-4627-4212-8900-70e3f0052f9f") }
            );


        builder.HasMany(q => q.Options)
            .WithOne(o => o.Question)
            .HasForeignKey(o => o.QuestionId);


        builder.Property(t => t.Text).IsRequired();
    }
}