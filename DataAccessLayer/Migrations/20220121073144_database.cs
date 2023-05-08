using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    AboutID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CvStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.AboutID);
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminID);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactUserName = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true),
                    ContactMail = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true),
                    ContactMessage = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ContactIp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContactStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactID);
                });

            migrationBuilder.CreateTable(
                name: "Education",
                columns: table => new
                {
                    EducationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducationName = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    EducationYear = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    EducationSection = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    EducationDegree = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    EducationStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Education", x => x.EducationID);
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    ExperienceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExperienceName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ExperienceYear = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    ExperienceDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ExperienceTask = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    ExperienceStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.ExperienceID);
                });

            migrationBuilder.CreateTable(
                name: "Interestss",
                columns: table => new
                {
                    InterestsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InterestsName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    InterestsPicture = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    InterestsStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interestss", x => x.InterestsID);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    LanguageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    LanguagePercent = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    LanguageStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.LanguageID);
                });

            migrationBuilder.CreateTable(
                name: "References",
                columns: table => new
                {
                    ReferenceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReferenceName = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true),
                    ReferencePhone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    ReferenceTask = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ReferenceMail = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true),
                    ReferenceStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_References", x => x.ReferenceID);
                });

            migrationBuilder.CreateTable(
                name: "Skillss",
                columns: table => new
                {
                    SkillsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillsName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    SkillsPercent = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    SkillsStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skillss", x => x.SkillsID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "Interestss");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "References");

            migrationBuilder.DropTable(
                name: "Skillss");
        }
    }
}
