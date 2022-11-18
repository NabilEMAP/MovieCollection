using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieCollection.DAL.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Country");

            migrationBuilder.EnsureSchema(
                name: "Director");

            migrationBuilder.EnsureSchema(
                name: "Genre");

            migrationBuilder.EnsureSchema(
                name: "Movie");

            migrationBuilder.EnsureSchema(
                name: "User");

            migrationBuilder.CreateTable(
                name: "tblCountries",
                schema: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(25)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCountries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblDirectors",
                schema: "Director",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(25)", nullable: false),
                    LastName = table.Column<string>(type: "varchar(25)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: false),
                    Nationality = table.Column<string>(type: "varchar(25)", nullable: false),
                    IsActive = table.Column<string>(type: "varchar(25)", nullable: false),
                    PicturePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDirectors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblGenres",
                schema: "Genre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(25)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblGenres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblUsers",
                schema: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(25)", nullable: false),
                    LastName = table.Column<string>(type: "varchar(25)", nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    IsActive = table.Column<string>(type: "varchar(25)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblMovies",
                schema: "Movie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(50)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "date", nullable: false),
                    DirectorId = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblMovies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblMovies_tblCountries_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "Country",
                        principalTable: "tblCountries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblMovies_tblDirectors_DirectorId",
                        column: x => x.DirectorId,
                        principalSchema: "Director",
                        principalTable: "tblDirectors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenreMovie",
                columns: table => new
                {
                    GenresId = table.Column<int>(type: "int", nullable: false),
                    MoviesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreMovie", x => new { x.GenresId, x.MoviesId });
                    table.ForeignKey(
                        name: "FK_GenreMovie_tblGenres_GenresId",
                        column: x => x.GenresId,
                        principalSchema: "Genre",
                        principalTable: "tblGenres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenreMovie_tblMovies_MoviesId",
                        column: x => x.MoviesId,
                        principalSchema: "Movie",
                        principalTable: "tblMovies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieUser",
                columns: table => new
                {
                    MoviesId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieUser", x => new { x.MoviesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_MovieUser_tblMovies_MoviesId",
                        column: x => x.MoviesId,
                        principalSchema: "Movie",
                        principalTable: "tblMovies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieUser_tblUsers_UsersId",
                        column: x => x.UsersId,
                        principalSchema: "User",
                        principalTable: "tblUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GenreMovie_MoviesId",
                table: "GenreMovie",
                column: "MoviesId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieUser_UsersId",
                table: "MovieUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_tblCountries_Id",
                schema: "Country",
                table: "tblCountries",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblCountries_Name",
                schema: "Country",
                table: "tblCountries",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblDirectors_Id",
                schema: "Director",
                table: "tblDirectors",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblGenres_Id",
                schema: "Genre",
                table: "tblGenres",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblGenres_Name",
                schema: "Genre",
                table: "tblGenres",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblMovies_CountryId",
                schema: "Movie",
                table: "tblMovies",
                column: "CountryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblMovies_DirectorId",
                schema: "Movie",
                table: "tblMovies",
                column: "DirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_tblMovies_Id",
                schema: "Movie",
                table: "tblMovies",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblMovies_ReleaseDate",
                schema: "Movie",
                table: "tblMovies",
                column: "ReleaseDate",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblMovies_Title",
                schema: "Movie",
                table: "tblMovies",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblUsers_Email",
                schema: "User",
                table: "tblUsers",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblUsers_Id",
                schema: "User",
                table: "tblUsers",
                column: "Id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GenreMovie");

            migrationBuilder.DropTable(
                name: "MovieUser");

            migrationBuilder.DropTable(
                name: "tblGenres",
                schema: "Genre");

            migrationBuilder.DropTable(
                name: "tblMovies",
                schema: "Movie");

            migrationBuilder.DropTable(
                name: "tblUsers",
                schema: "User");

            migrationBuilder.DropTable(
                name: "tblCountries",
                schema: "Country");

            migrationBuilder.DropTable(
                name: "tblDirectors",
                schema: "Director");
        }
    }
}
