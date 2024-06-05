using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PeopleLifestyleSurvey.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Surveys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FullName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ContactNumber = table.Column<string>(type: "TEXT", nullable: false),
                    LikesPizza = table.Column<bool>(type: "INTEGER", nullable: false),
                    LikesPasta = table.Column<bool>(type: "INTEGER", nullable: false),
                    LikesPapAndWors = table.Column<bool>(type: "INTEGER", nullable: false),
                    LikesOther = table.Column<bool>(type: "INTEGER", nullable: false),
                    MoviesRating = table.Column<int>(type: "INTEGER", nullable: false),
                    RadioRating = table.Column<int>(type: "INTEGER", nullable: false),
                    EatOutRating = table.Column<int>(type: "INTEGER", nullable: false),
                    TvRating = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surveys", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Surveys");
        }
    }
}
