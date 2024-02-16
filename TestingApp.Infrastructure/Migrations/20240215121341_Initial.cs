using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestingApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Tests_TestId",
                        column: x => x.TestId,
                        principalTable: "Tests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TestResults",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: false),
                    TestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TestResults_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTest",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTest", x => new { x.UserId, x.TestId });
                    table.ForeignKey(
                        name: "FK_UserTest_Tests_TestId",
                        column: x => x.TestId,
                        principalTable: "Tests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserTest_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Options",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false),
                    QuestionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Options", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Options_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestionResults",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuestionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChoseOptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RightAnswerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TestResultId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionResults_TestResults_TestResultId",
                        column: x => x.TestResultId,
                        principalTable: "TestResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { new Guid("3f8d19c8-4627-4212-8900-70e3f0052f9f"), "This test examines proficiency in Structured Query Language (SQL) and database management concepts. Questions may cover SQL syntax, database design principles, normalization, indexing, querying databases using SELECT statements, data manipulation (INSERT, UPDATE, DELETE), transaction management, and relational database concepts. ", "SQL Test" },
                    { new Guid("83c697b7-35a5-494d-a221-e1483371d597"), "The .NET test evaluates knowledge and skills related to the Microsoft .NET framework and ecosystem. Questions may cover various aspects of .NET development, including C#, ASP.NET, .NET Core, Entity Framework, web services, and application deployment. ", ".Net Test" },
                    { new Guid("c365b577-aa53-4027-962e-7a0854c5f0ea"), "This test assesses the understanding of object-oriented programming concepts. Questions may cover topics such as encapsulation, inheritance, polymorphism, object-oriented design principles, and design patterns.", "OOP Test" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "UserName" },
                values: new object[,]
                {
                    { new Guid("c12256f1-0ae5-4e3e-8443-a1b56d5676a0"), "3572d6025a6a37430c17cbd8356d53a3a1d394ded158811d973018f4b2d15f3b", "User2" },
                    { new Guid("c9e3194a-5c7f-469d-ab9d-9fb75a8ce8de"), "a4e4570c263dbfe7e7b01c451f5121f025c7bba885bb3c373ba4a578b4a7dca4", "User1" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "TestId", "Text" },
                values: new object[,]
                {
                    { new Guid("2b71aeb6-586d-4f9e-bced-6c0ead8aa64e"), new Guid("3f8d19c8-4627-4212-8900-70e3f0052f9f"), "What is the difference between SQL and NoSQL databases?" },
                    { new Guid("5a4316d8-d0b3-4e59-aab7-f61618a84249"), new Guid("c365b577-aa53-4027-962e-7a0854c5f0ea"), "What is encapsulation?" },
                    { new Guid("667bc105-73d3-4a00-b09d-e66787b2d7ad"), new Guid("3f8d19c8-4627-4212-8900-70e3f0052f9f"), "What is SQL?" },
                    { new Guid("94ca6708-6e25-4223-89fd-4d5dab7d1032"), new Guid("c365b577-aa53-4027-962e-7a0854c5f0ea"), "What is inheritance?" },
                    { new Guid("b5df5f8d-2e06-448e-87f8-92358be52299"), new Guid("83c697b7-35a5-494d-a221-e1483371d597"), "What is C#?" },
                    { new Guid("cf1559f6-01c3-435e-bc80-dd14f69794bf"), new Guid("83c697b7-35a5-494d-a221-e1483371d597"), "What is ASP.NET Core?" },
                    { new Guid("d6099063-78e9-4f76-bd18-67e988b298e5"), new Guid("83c697b7-35a5-494d-a221-e1483371d597"), "What is the .NET Framework?" },
                    { new Guid("d7cc7885-fc2e-4f51-a7f7-f05b0bf7dd7b"), new Guid("3f8d19c8-4627-4212-8900-70e3f0052f9f"), "What is a primary key in a database?" },
                    { new Guid("dc7a3076-5904-4b38-b412-87095750f67f"), new Guid("c365b577-aa53-4027-962e-7a0854c5f0ea"), "What is polymorphism?" }
                });

            migrationBuilder.InsertData(
                table: "UserTest",
                columns: new[] { "TestId", "UserId" },
                values: new object[,]
                {
                    { new Guid("3f8d19c8-4627-4212-8900-70e3f0052f9f"), new Guid("c12256f1-0ae5-4e3e-8443-a1b56d5676a0") },
                    { new Guid("83c697b7-35a5-494d-a221-e1483371d597"), new Guid("c12256f1-0ae5-4e3e-8443-a1b56d5676a0") },
                    { new Guid("c365b577-aa53-4027-962e-7a0854c5f0ea"), new Guid("c12256f1-0ae5-4e3e-8443-a1b56d5676a0") },
                    { new Guid("3f8d19c8-4627-4212-8900-70e3f0052f9f"), new Guid("c9e3194a-5c7f-469d-ab9d-9fb75a8ce8de") },
                    { new Guid("83c697b7-35a5-494d-a221-e1483371d597"), new Guid("c9e3194a-5c7f-469d-ab9d-9fb75a8ce8de") },
                    { new Guid("c365b577-aa53-4027-962e-7a0854c5f0ea"), new Guid("c9e3194a-5c7f-469d-ab9d-9fb75a8ce8de") }
                });

            migrationBuilder.InsertData(
                table: "Options",
                columns: new[] { "Id", "IsCorrect", "QuestionId", "Text" },
                values: new object[,]
                {
                    { new Guid("0be92c5d-ff13-476f-ae60-0435b0dd3b69"), true, new Guid("5a4316d8-d0b3-4e59-aab7-f61618a84249"), "Right answer" },
                    { new Guid("0f859f47-c48d-49ab-9a71-63a7580417b8"), false, new Guid("cf1559f6-01c3-435e-bc80-dd14f69794bf"), "Wrong answer" },
                    { new Guid("1538bb74-3f2a-4362-ba65-c2798c0b9782"), false, new Guid("667bc105-73d3-4a00-b09d-e66787b2d7ad"), "Wrong answer" },
                    { new Guid("19a0d326-0a72-4047-ba72-5b2f88bcbc25"), false, new Guid("cf1559f6-01c3-435e-bc80-dd14f69794bf"), "Wrong answer" },
                    { new Guid("1c5bdd53-b143-4a4e-9cde-3cc9c0183177"), false, new Guid("b5df5f8d-2e06-448e-87f8-92358be52299"), "Wrong answer" },
                    { new Guid("1d80672d-4ce4-4074-b93b-20f4a12a2a6e"), false, new Guid("dc7a3076-5904-4b38-b412-87095750f67f"), "Wrong answer" },
                    { new Guid("26017fab-043c-4682-9215-b11db21bab06"), false, new Guid("b5df5f8d-2e06-448e-87f8-92358be52299"), "Wrong answer" },
                    { new Guid("3359a8d3-e7fc-4960-abde-4944b836ed20"), false, new Guid("d7cc7885-fc2e-4f51-a7f7-f05b0bf7dd7b"), "Wrong answer" },
                    { new Guid("4d5875ef-05fa-45c8-9136-a2f9996e6205"), true, new Guid("cf1559f6-01c3-435e-bc80-dd14f69794bf"), "Right answer" },
                    { new Guid("519cb1a4-52cc-43a0-a74a-84b28d1af8e0"), true, new Guid("94ca6708-6e25-4223-89fd-4d5dab7d1032"), "Right answer" },
                    { new Guid("582044ff-bb5c-4b73-b5a0-12d7f4ae8404"), false, new Guid("2b71aeb6-586d-4f9e-bced-6c0ead8aa64e"), "Wrong answer" },
                    { new Guid("59aa522c-bbaa-494b-bbf9-6141ad7d4ac9"), false, new Guid("d6099063-78e9-4f76-bd18-67e988b298e5"), "Wrong answer" },
                    { new Guid("6e585a02-f92f-4427-bf5a-29d2a446e91c"), false, new Guid("94ca6708-6e25-4223-89fd-4d5dab7d1032"), "Wrong answer" },
                    { new Guid("83320354-259d-4920-a5bd-c19b847ee2f6"), true, new Guid("dc7a3076-5904-4b38-b412-87095750f67f"), "Right answer" },
                    { new Guid("8884e35f-e572-4ce6-91a2-b99cb0db5e99"), false, new Guid("94ca6708-6e25-4223-89fd-4d5dab7d1032"), "Wrong answer" },
                    { new Guid("90f7b804-580a-441a-9a7b-c390cb034ec7"), false, new Guid("d7cc7885-fc2e-4f51-a7f7-f05b0bf7dd7b"), "Wrong answer" },
                    { new Guid("9317620c-d452-423f-94ef-4d1d39048667"), true, new Guid("d6099063-78e9-4f76-bd18-67e988b298e5"), "Right answer" },
                    { new Guid("93e5e5a5-fd67-4d86-8f3b-92bb4a00fff5"), true, new Guid("d7cc7885-fc2e-4f51-a7f7-f05b0bf7dd7b"), "Right answer" },
                    { new Guid("9b717650-0c1e-4da0-a4c9-89a90cd13a17"), false, new Guid("2b71aeb6-586d-4f9e-bced-6c0ead8aa64e"), "Wrong answer" },
                    { new Guid("a4e2d54c-be74-43e7-85a1-80f8d1bdd3d3"), false, new Guid("667bc105-73d3-4a00-b09d-e66787b2d7ad"), "Wrong answer" },
                    { new Guid("ac42e308-01c4-413c-9504-54912b89d9ce"), true, new Guid("2b71aeb6-586d-4f9e-bced-6c0ead8aa64e"), "Right answer" },
                    { new Guid("b4bb4add-7a99-4183-8685-5f4ba8d39309"), false, new Guid("dc7a3076-5904-4b38-b412-87095750f67f"), "Wrong answer" },
                    { new Guid("c9a0dd2a-0a90-40ec-a391-ea5b94113905"), true, new Guid("667bc105-73d3-4a00-b09d-e66787b2d7ad"), "Right answer" },
                    { new Guid("ca0786a1-740e-4312-85b5-353ad5f10b3a"), false, new Guid("5a4316d8-d0b3-4e59-aab7-f61618a84249"), "Wrong answer" },
                    { new Guid("e534afea-f89e-4b6b-a2e2-fe9a2cee16ee"), true, new Guid("b5df5f8d-2e06-448e-87f8-92358be52299"), "Right answer" },
                    { new Guid("e9e288b3-b111-4cf5-9526-814e389b05bb"), false, new Guid("5a4316d8-d0b3-4e59-aab7-f61618a84249"), "Wrong answer" },
                    { new Guid("f525c248-21f3-4e94-b77a-08f8d1a1ac37"), false, new Guid("d6099063-78e9-4f76-bd18-67e988b298e5"), "Wrong answer" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Options_QuestionId",
                table: "Options",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionResults_TestResultId",
                table: "QuestionResults",
                column: "TestResultId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_TestId",
                table: "Questions",
                column: "TestId");

            migrationBuilder.CreateIndex(
                name: "IX_TestResults_UserId",
                table: "TestResults",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTest_TestId",
                table: "UserTest",
                column: "TestId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Options");

            migrationBuilder.DropTable(
                name: "QuestionResults");

            migrationBuilder.DropTable(
                name: "UserTest");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "TestResults");

            migrationBuilder.DropTable(
                name: "Tests");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
