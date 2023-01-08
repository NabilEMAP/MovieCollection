using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieCollection.DAL.Migrations
{
    public partial class InitialMigration02a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_tblMovies_Title",
                schema: "Movie",
                table: "tblMovies");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_tblMovies_Title",
                schema: "Movie",
                table: "tblMovies",
                column: "Title",
                unique: true);
        }
    }
}
