using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AjaxApp.Migrations
{
    public partial class Movies_Migration_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MoviesConnectionDB",
                columns: table => new
                {
                    IdMovies = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Genre = table.Column<string>(nullable: true),
                    RateMovie = table.Column<int>(nullable: true),
                    Price = table.Column<int>(nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: true),
                    MainCharacter = table.Column<string>(nullable: true),
                    DirectedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoviesConnectionDB", x => x.IdMovies);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MoviesConnectionDB");
        }
    }
}
