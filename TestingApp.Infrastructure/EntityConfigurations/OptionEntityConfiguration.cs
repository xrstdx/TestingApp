using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TestingApp.Domain.Entities;

namespace TestingApp.Infrastructure.EntityConfigurations;

public class OptionEntityConfiguration : IEntityTypeConfiguration<Option>
{
    public void Configure(EntityTypeBuilder<Option> builder)
    {
        builder.ToTable("Options");

        builder.HasKey(o => o.Id);

        builder.HasData(
            new Option { Id = Guid.NewGuid(), Text = "Right answer", IsCorrect = true, QuestionId = Guid.Parse("5a4316d8-d0b3-4e59-aab7-f61618a84249") },
            new Option { Id = Guid.NewGuid(), Text = "Wrong answer", IsCorrect = false, QuestionId = Guid.Parse("5a4316d8-d0b3-4e59-aab7-f61618a84249") },
            new Option { Id = Guid.NewGuid(), Text = "Wrong answer", IsCorrect = false, QuestionId = Guid.Parse("5a4316d8-d0b3-4e59-aab7-f61618a84249") },

            new Option { Id = Guid.NewGuid(), Text = "Wrong answer", IsCorrect = false, QuestionId = Guid.Parse("94ca6708-6e25-4223-89fd-4d5dab7d1032") },
            new Option { Id = Guid.NewGuid(), Text = "Wrong answer", IsCorrect = false, QuestionId = Guid.Parse("94ca6708-6e25-4223-89fd-4d5dab7d1032") },
            new Option { Id = Guid.NewGuid(), Text = "Right answer", IsCorrect = true, QuestionId = Guid.Parse("94ca6708-6e25-4223-89fd-4d5dab7d1032") },

            new Option { Id = Guid.NewGuid(), Text = "Wrong answer", IsCorrect = false, QuestionId = Guid.Parse("dc7a3076-5904-4b38-b412-87095750f67f") },
            new Option { Id = Guid.NewGuid(), Text = "Wrong answer", IsCorrect = false, QuestionId = Guid.Parse("dc7a3076-5904-4b38-b412-87095750f67f") },
            new Option { Id = Guid.NewGuid(), Text = "Right answer", IsCorrect = true, QuestionId = Guid.Parse("dc7a3076-5904-4b38-b412-87095750f67f") },


            new Option { Id = Guid.NewGuid(), Text = "Right answer", IsCorrect = true, QuestionId = Guid.Parse("b5df5f8d-2e06-448e-87f8-92358be52299") },
            new Option { Id = Guid.NewGuid(), Text = "Wrong answer", IsCorrect = false, QuestionId = Guid.Parse("b5df5f8d-2e06-448e-87f8-92358be52299") },
            new Option { Id = Guid.NewGuid(), Text = "Wrong answer", IsCorrect = false, QuestionId = Guid.Parse("b5df5f8d-2e06-448e-87f8-92358be52299") },

            new Option { Id = Guid.NewGuid(), Text = "Wrong answer", IsCorrect = false, QuestionId = Guid.Parse("d6099063-78e9-4f76-bd18-67e988b298e5") },
            new Option { Id = Guid.NewGuid(), Text = "Right answer", IsCorrect = true, QuestionId = Guid.Parse("d6099063-78e9-4f76-bd18-67e988b298e5") },
            new Option { Id = Guid.NewGuid(), Text = "Wrong answer", IsCorrect = false, QuestionId = Guid.Parse("d6099063-78e9-4f76-bd18-67e988b298e5") },

            new Option { Id = Guid.NewGuid(), Text = "Wrong answer", IsCorrect = false, QuestionId = Guid.Parse("cf1559f6-01c3-435e-bc80-dd14f69794bf") },
            new Option { Id = Guid.NewGuid(), Text = "Wrong answer", IsCorrect = false, QuestionId = Guid.Parse("cf1559f6-01c3-435e-bc80-dd14f69794bf") },
            new Option { Id = Guid.NewGuid(), Text = "Right answer", IsCorrect = true, QuestionId = Guid.Parse("cf1559f6-01c3-435e-bc80-dd14f69794bf") },


            new Option { Id = Guid.NewGuid(), Text = "Right answer", IsCorrect = true, QuestionId = Guid.Parse("667bc105-73d3-4a00-b09d-e66787b2d7ad") },
            new Option { Id = Guid.NewGuid(), Text = "Wrong answer", IsCorrect = false, QuestionId = Guid.Parse("667bc105-73d3-4a00-b09d-e66787b2d7ad") },
            new Option { Id = Guid.NewGuid(), Text = "Wrong answer", IsCorrect = false, QuestionId = Guid.Parse("667bc105-73d3-4a00-b09d-e66787b2d7ad") },

            new Option { Id = Guid.NewGuid(), Text = "Right answer", IsCorrect = true, QuestionId = Guid.Parse("d7cc7885-fc2e-4f51-a7f7-f05b0bf7dd7b") },
            new Option { Id = Guid.NewGuid(), Text = "Wrong answer", IsCorrect = false, QuestionId = Guid.Parse("d7cc7885-fc2e-4f51-a7f7-f05b0bf7dd7b") },
            new Option { Id = Guid.NewGuid(), Text = "Wrong answer", IsCorrect = false, QuestionId = Guid.Parse("d7cc7885-fc2e-4f51-a7f7-f05b0bf7dd7b") },

            new Option { Id = Guid.NewGuid(), Text = "Wrong answer", IsCorrect = false, QuestionId = Guid.Parse("2b71aeb6-586d-4f9e-bced-6c0ead8aa64e") },
            new Option { Id = Guid.NewGuid(), Text = "Wrong answer", IsCorrect = false, QuestionId = Guid.Parse("2b71aeb6-586d-4f9e-bced-6c0ead8aa64e") },
            new Option { Id = Guid.NewGuid(), Text = "Right answer", IsCorrect = true, QuestionId = Guid.Parse("2b71aeb6-586d-4f9e-bced-6c0ead8aa64e") }

        );


        builder.Property(t => t.Text).IsRequired();
    }
}
