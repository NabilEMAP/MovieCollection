using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieCollection.DAL.Migrations
{
    public partial class InitialMigration02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_tblMovies_ReleaseDate",
                schema: "Movie",
                table: "tblMovies");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_tblMovies_ReleaseDate",
                schema: "Movie",
                table: "tblMovies",
                column: "ReleaseDate",
                unique: true);
        }
    }
}
