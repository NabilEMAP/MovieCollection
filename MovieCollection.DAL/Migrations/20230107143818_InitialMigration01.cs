using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieCollection.DAL.Migrations
{
    public partial class InitialMigration01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MovieGenre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieGenre", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieGenre_tblGenres_GenreId",
                        column: x => x.GenreId,
                        principalSchema: "Genre",
                        principalTable: "tblGenres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieGenre_tblMovies_MovieId",
                        column: x => x.MovieId,
                        principalSchema: "Movie",
                        principalTable: "tblMovies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblMovies_CountryId",
                schema: "Movie",
                table: "tblMovies",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_tblMovies_DirectorId",
                schema: "Movie",
                table: "tblMovies",
                column: "DirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieGenre_GenreId",
                table: "MovieGenre",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieGenre_MovieId",
                table: "MovieGenre",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblMovies_tblCountries_CountryId",
                schema: "Movie",
                table: "tblMovies",
                column: "CountryId",
                principalSchema: "Country",
                principalTable: "tblCountries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tblMovies_tblDirectors_DirectorId",
                schema: "Movie",
                table: "tblMovies",
                column: "DirectorId",
                principalSchema: "Director",
                principalTable: "tblDirectors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblMovies_tblCountries_CountryId",
                schema: "Movie",
                table: "tblMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_tblMovies_tblDirectors_DirectorId",
                schema: "Movie",
                table: "tblMovies");

            migrationBuilder.DropTable(
                name: "MovieGenre");

            migrationBuilder.DropIndex(
                name: "IX_tblMovies_CountryId",
                schema: "Movie",
                table: "tblMovies");

            migrationBuilder.DropIndex(
                name: "IX_tblMovies_DirectorId",
                schema: "Movie",
                table: "tblMovies");
        }
    }
}
