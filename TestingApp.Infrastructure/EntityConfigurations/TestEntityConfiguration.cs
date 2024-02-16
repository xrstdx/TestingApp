using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TestingApp.Domain.Entities;

namespace TestingApp.Infrastructure.EntityConfigurations;

public class TestEntityConfiguration : IEntityTypeConfiguration<Test>
{
    public void Configure(EntityTypeBuilder<Test> builder)
    {
        builder.ToTable("Tests");

        builder.HasKey(t => t.Id);

        builder.HasData(
            new Test
            {
                Id = Guid.Parse("c365b577-aa53-4027-962e-7a0854c5f0ea"),
                Title = "OOP Test",
                Description = "This test assesses the understanding of object-oriented programming concepts. " +
                "Questions may cover topics such as encapsulation, inheritance, polymorphism, object-oriented design principles, " +
                "and design patterns.",
            },
            new Test
            {
                Id = Guid.Parse("83c697b7-35a5-494d-a221-e1483371d597"),
                Title = ".Net Test",
                Description = "The .NET test evaluates knowledge and skills related to the Microsoft .NET framework and ecosystem. " +
                "Questions may cover various aspects of .NET development, including C#, ASP.NET, .NET Core, Entity Framework, web services, " +
                "and application deployment. ",
            },
            new Test
            {
                Id = Guid.Parse("3f8d19c8-4627-4212-8900-70e3f0052f9f"),
                Title = "SQL Test",
                Description = "This test examines proficiency in Structured Query Language (SQL) and database management concepts. " +
                "Questions may cover SQL syntax, database design principles, normalization, indexing, querying databases using SELECT statements, " +
                "data manipulation (INSERT, UPDATE, DELETE), transaction management, and relational database concepts. ",
            }
            );

        builder.HasMany(t => t.Questions)
            .WithOne(q => q.Test)
            .HasForeignKey(q => q.TestId);

        builder.Property(t => t.Title).IsRequired();
        builder.Property(t => t.Description).IsRequired();
    }
}
