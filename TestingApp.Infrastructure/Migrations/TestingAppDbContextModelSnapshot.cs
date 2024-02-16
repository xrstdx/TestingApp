﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestingApp.Infrastructure.Contexts;

#nullable disable

namespace TestingApp.Infrastructure.Migrations
{
    [DbContext(typeof(TestingAppDbContext))]
    partial class TestingAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TestingApp.Domain.Entities.Option", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("bit");

                    b.Property<Guid>("QuestionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Options", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("0be92c5d-ff13-476f-ae60-0435b0dd3b69"),
                            IsCorrect = true,
                            QuestionId = new Guid("5a4316d8-d0b3-4e59-aab7-f61618a84249"),
                            Text = "Right answer"
                        },
                        new
                        {
                            Id = new Guid("ca0786a1-740e-4312-85b5-353ad5f10b3a"),
                            IsCorrect = false,
                            QuestionId = new Guid("5a4316d8-d0b3-4e59-aab7-f61618a84249"),
                            Text = "Wrong answer"
                        },
                        new
                        {
                            Id = new Guid("e9e288b3-b111-4cf5-9526-814e389b05bb"),
                            IsCorrect = false,
                            QuestionId = new Guid("5a4316d8-d0b3-4e59-aab7-f61618a84249"),
                            Text = "Wrong answer"
                        },
                        new
                        {
                            Id = new Guid("8884e35f-e572-4ce6-91a2-b99cb0db5e99"),
                            IsCorrect = false,
                            QuestionId = new Guid("94ca6708-6e25-4223-89fd-4d5dab7d1032"),
                            Text = "Wrong answer"
                        },
                        new
                        {
                            Id = new Guid("6e585a02-f92f-4427-bf5a-29d2a446e91c"),
                            IsCorrect = false,
                            QuestionId = new Guid("94ca6708-6e25-4223-89fd-4d5dab7d1032"),
                            Text = "Wrong answer"
                        },
                        new
                        {
                            Id = new Guid("519cb1a4-52cc-43a0-a74a-84b28d1af8e0"),
                            IsCorrect = true,
                            QuestionId = new Guid("94ca6708-6e25-4223-89fd-4d5dab7d1032"),
                            Text = "Right answer"
                        },
                        new
                        {
                            Id = new Guid("1d80672d-4ce4-4074-b93b-20f4a12a2a6e"),
                            IsCorrect = false,
                            QuestionId = new Guid("dc7a3076-5904-4b38-b412-87095750f67f"),
                            Text = "Wrong answer"
                        },
                        new
                        {
                            Id = new Guid("b4bb4add-7a99-4183-8685-5f4ba8d39309"),
                            IsCorrect = false,
                            QuestionId = new Guid("dc7a3076-5904-4b38-b412-87095750f67f"),
                            Text = "Wrong answer"
                        },
                        new
                        {
                            Id = new Guid("83320354-259d-4920-a5bd-c19b847ee2f6"),
                            IsCorrect = true,
                            QuestionId = new Guid("dc7a3076-5904-4b38-b412-87095750f67f"),
                            Text = "Right answer"
                        },
                        new
                        {
                            Id = new Guid("e534afea-f89e-4b6b-a2e2-fe9a2cee16ee"),
                            IsCorrect = true,
                            QuestionId = new Guid("b5df5f8d-2e06-448e-87f8-92358be52299"),
                            Text = "Right answer"
                        },
                        new
                        {
                            Id = new Guid("1c5bdd53-b143-4a4e-9cde-3cc9c0183177"),
                            IsCorrect = false,
                            QuestionId = new Guid("b5df5f8d-2e06-448e-87f8-92358be52299"),
                            Text = "Wrong answer"
                        },
                        new
                        {
                            Id = new Guid("26017fab-043c-4682-9215-b11db21bab06"),
                            IsCorrect = false,
                            QuestionId = new Guid("b5df5f8d-2e06-448e-87f8-92358be52299"),
                            Text = "Wrong answer"
                        },
                        new
                        {
                            Id = new Guid("59aa522c-bbaa-494b-bbf9-6141ad7d4ac9"),
                            IsCorrect = false,
                            QuestionId = new Guid("d6099063-78e9-4f76-bd18-67e988b298e5"),
                            Text = "Wrong answer"
                        },
                        new
                        {
                            Id = new Guid("9317620c-d452-423f-94ef-4d1d39048667"),
                            IsCorrect = true,
                            QuestionId = new Guid("d6099063-78e9-4f76-bd18-67e988b298e5"),
                            Text = "Right answer"
                        },
                        new
                        {
                            Id = new Guid("f525c248-21f3-4e94-b77a-08f8d1a1ac37"),
                            IsCorrect = false,
                            QuestionId = new Guid("d6099063-78e9-4f76-bd18-67e988b298e5"),
                            Text = "Wrong answer"
                        },
                        new
                        {
                            Id = new Guid("0f859f47-c48d-49ab-9a71-63a7580417b8"),
                            IsCorrect = false,
                            QuestionId = new Guid("cf1559f6-01c3-435e-bc80-dd14f69794bf"),
                            Text = "Wrong answer"
                        },
                        new
                        {
                            Id = new Guid("19a0d326-0a72-4047-ba72-5b2f88bcbc25"),
                            IsCorrect = false,
                            QuestionId = new Guid("cf1559f6-01c3-435e-bc80-dd14f69794bf"),
                            Text = "Wrong answer"
                        },
                        new
                        {
                            Id = new Guid("4d5875ef-05fa-45c8-9136-a2f9996e6205"),
                            IsCorrect = true,
                            QuestionId = new Guid("cf1559f6-01c3-435e-bc80-dd14f69794bf"),
                            Text = "Right answer"
                        },
                        new
                        {
                            Id = new Guid("c9a0dd2a-0a90-40ec-a391-ea5b94113905"),
                            IsCorrect = true,
                            QuestionId = new Guid("667bc105-73d3-4a00-b09d-e66787b2d7ad"),
                            Text = "Right answer"
                        },
                        new
                        {
                            Id = new Guid("a4e2d54c-be74-43e7-85a1-80f8d1bdd3d3"),
                            IsCorrect = false,
                            QuestionId = new Guid("667bc105-73d3-4a00-b09d-e66787b2d7ad"),
                            Text = "Wrong answer"
                        },
                        new
                        {
                            Id = new Guid("1538bb74-3f2a-4362-ba65-c2798c0b9782"),
                            IsCorrect = false,
                            QuestionId = new Guid("667bc105-73d3-4a00-b09d-e66787b2d7ad"),
                            Text = "Wrong answer"
                        },
                        new
                        {
                            Id = new Guid("93e5e5a5-fd67-4d86-8f3b-92bb4a00fff5"),
                            IsCorrect = true,
                            QuestionId = new Guid("d7cc7885-fc2e-4f51-a7f7-f05b0bf7dd7b"),
                            Text = "Right answer"
                        },
                        new
                        {
                            Id = new Guid("3359a8d3-e7fc-4960-abde-4944b836ed20"),
                            IsCorrect = false,
                            QuestionId = new Guid("d7cc7885-fc2e-4f51-a7f7-f05b0bf7dd7b"),
                            Text = "Wrong answer"
                        },
                        new
                        {
                            Id = new Guid("90f7b804-580a-441a-9a7b-c390cb034ec7"),
                            IsCorrect = false,
                            QuestionId = new Guid("d7cc7885-fc2e-4f51-a7f7-f05b0bf7dd7b"),
                            Text = "Wrong answer"
                        },
                        new
                        {
                            Id = new Guid("9b717650-0c1e-4da0-a4c9-89a90cd13a17"),
                            IsCorrect = false,
                            QuestionId = new Guid("2b71aeb6-586d-4f9e-bced-6c0ead8aa64e"),
                            Text = "Wrong answer"
                        },
                        new
                        {
                            Id = new Guid("582044ff-bb5c-4b73-b5a0-12d7f4ae8404"),
                            IsCorrect = false,
                            QuestionId = new Guid("2b71aeb6-586d-4f9e-bced-6c0ead8aa64e"),
                            Text = "Wrong answer"
                        },
                        new
                        {
                            Id = new Guid("ac42e308-01c4-413c-9504-54912b89d9ce"),
                            IsCorrect = true,
                            QuestionId = new Guid("2b71aeb6-586d-4f9e-bced-6c0ead8aa64e"),
                            Text = "Right answer"
                        });
                });

            modelBuilder.Entity("TestingApp.Domain.Entities.Question", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TestId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TestId");

                    b.ToTable("Questions", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("5a4316d8-d0b3-4e59-aab7-f61618a84249"),
                            TestId = new Guid("c365b577-aa53-4027-962e-7a0854c5f0ea"),
                            Text = "What is encapsulation?"
                        },
                        new
                        {
                            Id = new Guid("94ca6708-6e25-4223-89fd-4d5dab7d1032"),
                            TestId = new Guid("c365b577-aa53-4027-962e-7a0854c5f0ea"),
                            Text = "What is inheritance?"
                        },
                        new
                        {
                            Id = new Guid("dc7a3076-5904-4b38-b412-87095750f67f"),
                            TestId = new Guid("c365b577-aa53-4027-962e-7a0854c5f0ea"),
                            Text = "What is polymorphism?"
                        },
                        new
                        {
                            Id = new Guid("b5df5f8d-2e06-448e-87f8-92358be52299"),
                            TestId = new Guid("83c697b7-35a5-494d-a221-e1483371d597"),
                            Text = "What is C#?"
                        },
                        new
                        {
                            Id = new Guid("d6099063-78e9-4f76-bd18-67e988b298e5"),
                            TestId = new Guid("83c697b7-35a5-494d-a221-e1483371d597"),
                            Text = "What is the .NET Framework?"
                        },
                        new
                        {
                            Id = new Guid("cf1559f6-01c3-435e-bc80-dd14f69794bf"),
                            TestId = new Guid("83c697b7-35a5-494d-a221-e1483371d597"),
                            Text = "What is ASP.NET Core?"
                        },
                        new
                        {
                            Id = new Guid("667bc105-73d3-4a00-b09d-e66787b2d7ad"),
                            TestId = new Guid("3f8d19c8-4627-4212-8900-70e3f0052f9f"),
                            Text = "What is SQL?"
                        },
                        new
                        {
                            Id = new Guid("d7cc7885-fc2e-4f51-a7f7-f05b0bf7dd7b"),
                            TestId = new Guid("3f8d19c8-4627-4212-8900-70e3f0052f9f"),
                            Text = "What is a primary key in a database?"
                        },
                        new
                        {
                            Id = new Guid("2b71aeb6-586d-4f9e-bced-6c0ead8aa64e"),
                            TestId = new Guid("3f8d19c8-4627-4212-8900-70e3f0052f9f"),
                            Text = "What is the difference between SQL and NoSQL databases?"
                        });
                });

            modelBuilder.Entity("TestingApp.Domain.Entities.QuestionResult", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ChoseOptionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("QuestionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RightAnswerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TestResultId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TestResultId");

                    b.ToTable("QuestionResults", (string)null);
                });

            modelBuilder.Entity("TestingApp.Domain.Entities.Test", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tests", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("c365b577-aa53-4027-962e-7a0854c5f0ea"),
                            Description = "This test assesses the understanding of object-oriented programming concepts. Questions may cover topics such as encapsulation, inheritance, polymorphism, object-oriented design principles, and design patterns.",
                            Title = "OOP Test"
                        },
                        new
                        {
                            Id = new Guid("83c697b7-35a5-494d-a221-e1483371d597"),
                            Description = "The .NET test evaluates knowledge and skills related to the Microsoft .NET framework and ecosystem. Questions may cover various aspects of .NET development, including C#, ASP.NET, .NET Core, Entity Framework, web services, and application deployment. ",
                            Title = ".Net Test"
                        },
                        new
                        {
                            Id = new Guid("3f8d19c8-4627-4212-8900-70e3f0052f9f"),
                            Description = "This test examines proficiency in Structured Query Language (SQL) and database management concepts. Questions may cover SQL syntax, database design principles, normalization, indexing, querying databases using SELECT statements, data manipulation (INSERT, UPDATE, DELETE), transaction management, and relational database concepts. ",
                            Title = "SQL Test"
                        });
                });

            modelBuilder.Entity("TestingApp.Domain.Entities.TestResult", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<Guid>("TestId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("TestResults", (string)null);
                });

            modelBuilder.Entity("TestingApp.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("c9e3194a-5c7f-469d-ab9d-9fb75a8ce8de"),
                            PasswordHash = "a4e4570c263dbfe7e7b01c451f5121f025c7bba885bb3c373ba4a578b4a7dca4",
                            UserName = "User1"
                        },
                        new
                        {
                            Id = new Guid("c12256f1-0ae5-4e3e-8443-a1b56d5676a0"),
                            PasswordHash = "3572d6025a6a37430c17cbd8356d53a3a1d394ded158811d973018f4b2d15f3b",
                            UserName = "User2"
                        });
                });

            modelBuilder.Entity("TestingApp.Domain.Entities.UserTest", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TestId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "TestId");

                    b.HasIndex("TestId");

                    b.ToTable("UserTest", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("c9e3194a-5c7f-469d-ab9d-9fb75a8ce8de"),
                            TestId = new Guid("c365b577-aa53-4027-962e-7a0854c5f0ea")
                        },
                        new
                        {
                            UserId = new Guid("c9e3194a-5c7f-469d-ab9d-9fb75a8ce8de"),
                            TestId = new Guid("83c697b7-35a5-494d-a221-e1483371d597")
                        },
                        new
                        {
                            UserId = new Guid("c9e3194a-5c7f-469d-ab9d-9fb75a8ce8de"),
                            TestId = new Guid("3f8d19c8-4627-4212-8900-70e3f0052f9f")
                        },
                        new
                        {
                            UserId = new Guid("c12256f1-0ae5-4e3e-8443-a1b56d5676a0"),
                            TestId = new Guid("c365b577-aa53-4027-962e-7a0854c5f0ea")
                        },
                        new
                        {
                            UserId = new Guid("c12256f1-0ae5-4e3e-8443-a1b56d5676a0"),
                            TestId = new Guid("83c697b7-35a5-494d-a221-e1483371d597")
                        },
                        new
                        {
                            UserId = new Guid("c12256f1-0ae5-4e3e-8443-a1b56d5676a0"),
                            TestId = new Guid("3f8d19c8-4627-4212-8900-70e3f0052f9f")
                        });
                });

            modelBuilder.Entity("TestingApp.Domain.Entities.Option", b =>
                {
                    b.HasOne("TestingApp.Domain.Entities.Question", "Question")
                        .WithMany("Options")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("TestingApp.Domain.Entities.Question", b =>
                {
                    b.HasOne("TestingApp.Domain.Entities.Test", "Test")
                        .WithMany("Questions")
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Test");
                });

            modelBuilder.Entity("TestingApp.Domain.Entities.QuestionResult", b =>
                {
                    b.HasOne("TestingApp.Domain.Entities.TestResult", "TestResult")
                        .WithMany("QuestionResults")
                        .HasForeignKey("TestResultId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TestResult");
                });

            modelBuilder.Entity("TestingApp.Domain.Entities.TestResult", b =>
                {
                    b.HasOne("TestingApp.Domain.Entities.User", "User")
                        .WithMany("TestResults")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TestingApp.Domain.Entities.UserTest", b =>
                {
                    b.HasOne("TestingApp.Domain.Entities.Test", null)
                        .WithMany()
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestingApp.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TestingApp.Domain.Entities.Question", b =>
                {
                    b.Navigation("Options");
                });

            modelBuilder.Entity("TestingApp.Domain.Entities.Test", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("TestingApp.Domain.Entities.TestResult", b =>
                {
                    b.Navigation("QuestionResults");
                });

            modelBuilder.Entity("TestingApp.Domain.Entities.User", b =>
                {
                    b.Navigation("TestResults");
                });
#pragma warning restore 612, 618
        }
    }
}
