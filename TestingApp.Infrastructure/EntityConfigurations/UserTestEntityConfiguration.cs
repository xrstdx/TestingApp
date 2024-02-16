using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TestingApp.Domain.Entities;

namespace TestingApp.Infrastructure.EntityConfigurations;

public class UserTestEntityConfiguration : IEntityTypeConfiguration<UserTest>
{
    public void Configure(EntityTypeBuilder<UserTest> builder)
    {
        builder.ToTable("UserTest");

        builder.HasKey(ut => new { ut.UserId, ut.TestId });


        builder.HasData(
                    new UserTest { UserId = Guid.Parse("c9e3194a-5c7f-469d-ab9d-9fb75a8ce8de"), TestId = Guid.Parse("c365b577-aa53-4027-962e-7a0854c5f0ea")},
                    new UserTest { UserId = Guid.Parse("c9e3194a-5c7f-469d-ab9d-9fb75a8ce8de"), TestId = Guid.Parse("83c697b7-35a5-494d-a221-e1483371d597")},
                    new UserTest { UserId = Guid.Parse("c9e3194a-5c7f-469d-ab9d-9fb75a8ce8de"), TestId = Guid.Parse("3f8d19c8-4627-4212-8900-70e3f0052f9f")},
                    new UserTest { UserId = Guid.Parse("c12256f1-0ae5-4e3e-8443-a1b56d5676a0"), TestId = Guid.Parse("c365b577-aa53-4027-962e-7a0854c5f0ea")},
                    new UserTest { UserId = Guid.Parse("c12256f1-0ae5-4e3e-8443-a1b56d5676a0"), TestId = Guid.Parse("83c697b7-35a5-494d-a221-e1483371d597")},
                    new UserTest { UserId = Guid.Parse("c12256f1-0ae5-4e3e-8443-a1b56d5676a0"), TestId = Guid.Parse("3f8d19c8-4627-4212-8900-70e3f0052f9f") }
                    );

    }
}
