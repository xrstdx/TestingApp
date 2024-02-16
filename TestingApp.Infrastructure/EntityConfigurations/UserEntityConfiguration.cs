using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TestingApp.Application.Helpers;
using TestingApp.Domain.Entities;

namespace TestingApp.Infrastructure.EntityConfigurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");

        builder.HasKey(e => e.Id);

        builder.HasData(
            new User
            {
                Id = Guid.Parse("c9e3194a-5c7f-469d-ab9d-9fb75a8ce8de"),
                UserName = "User1",
                PasswordHash = PasswordHelper.HashPassword("user1password"),
            },
            new User
            {
                Id = Guid.Parse("c12256f1-0ae5-4e3e-8443-a1b56d5676a0"),
                UserName = "User2",
                PasswordHash = PasswordHelper.HashPassword("user2password"),
            });

        builder.HasMany(u => u.TestResults)
            .WithOne(tr => tr.User)
            .HasForeignKey(tr => tr.UserId);

        builder.HasMany(u => u.Tests)
            .WithMany(t => t.Users)
            .UsingEntity<UserTest>();


        builder.Property(u => u.UserName).IsRequired();
        builder.Property(u => u.PasswordHash).IsRequired();
    }
}