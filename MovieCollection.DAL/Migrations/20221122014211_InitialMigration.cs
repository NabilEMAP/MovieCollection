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
                    Name = table.Column<string>(type: "varchar(100)", nullable: false)
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

            migrationBuilder.InsertData(
                schema: "Country",
                table: "tblCountries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Afghanistan" },
                    { 2, "Albania" },
                    { 3, "Algeria" },
                    { 4, "Andorra" },
                    { 5, "Angola" },
                    { 6, "Antigua and Barbuda" },
                    { 7, "Argentina" },
                    { 8, "Armenia" },
                    { 9, "Australia" },
                    { 10, "Austria" },
                    { 11, "Azerbaijan" },
                    { 12, "Bahamas" },
                    { 13, "Bahrain" },
                    { 14, "Bangladesh" },
                    { 15, "Barbados" },
                    { 16, "Belarus" },
                    { 17, "Belgium" },
                    { 18, "Belize" },
                    { 19, "Benin" },
                    { 20, "Bhutan" },
                    { 21, "Bolivia" },
                    { 22, "Bosnia and Herzegovina" },
                    { 23, "Botswana" },
                    { 24, "Brazil" },
                    { 25, "Brunei" },
                    { 26, "Bulgaria" },
                    { 27, "Burkina Faso" },
                    { 28, "Burundi" },
                    { 29, "Côte d'Ivoire" },
                    { 30, "Cabo Verde" },
                    { 31, "Cambodia" },
                    { 32, "Cameroon" },
                    { 33, "Canada" },
                    { 34, "Central African Republic" },
                    { 35, "Chad" },
                    { 36, "Chile" },
                    { 37, "China" },
                    { 38, "Colombia" },
                    { 39, "Comoros" },
                    { 40, "Congo (Congo-Brazzaville)" },
                    { 41, "Costa Rica" },
                    { 42, "Croatia" }
                });

            migrationBuilder.InsertData(
                schema: "Country",
                table: "tblCountries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 43, "Cuba" },
                    { 44, "Cyprus" },
                    { 45, "Czechia (Czech Republic)" },
                    { 46, "Democratic Republic of the Congo" },
                    { 47, "Denmark" },
                    { 48, "Djibouti" },
                    { 49, "Dominica" },
                    { 50, "Dominican Republic" },
                    { 51, "Ecuador" },
                    { 52, "Egypt" },
                    { 53, "El Salvador" },
                    { 54, "Equatorial Guinea" },
                    { 55, "Eritrea" },
                    { 56, "Estonia" },
                    { 57, "Eswatini (fmr. \"Swaziland\")" },
                    { 58, "Ethiopia" },
                    { 59, "Fiji" },
                    { 60, "Finland	" },
                    { 61, "France" },
                    { 62, "Gabon" },
                    { 63, "Gambia" },
                    { 64, "Georgia" },
                    { 65, "Germany" },
                    { 66, "Ghana" },
                    { 67, "Greece" },
                    { 68, "Grenada" },
                    { 69, "Guatemala" },
                    { 70, "Guinea" },
                    { 71, "Guinea-Bissau" },
                    { 72, "Guyana" },
                    { 73, "Haiti" },
                    { 74, "Holy See" },
                    { 75, "Honduras" },
                    { 76, "Hungary" },
                    { 77, "Iceland" },
                    { 78, "India" },
                    { 79, "Indonesia" },
                    { 80, "Iran" },
                    { 81, "Iraq" },
                    { 82, "Ireland" },
                    { 83, "Israel" },
                    { 84, "Italy" }
                });

            migrationBuilder.InsertData(
                schema: "Country",
                table: "tblCountries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 85, "Jamaica" },
                    { 86, "Japan" },
                    { 87, "Jordan" },
                    { 88, "Kazakhstan" },
                    { 89, "Kenya" },
                    { 90, "Kiribati" },
                    { 91, "Kuwait" },
                    { 92, "Kyrgyzstan" },
                    { 93, "Laos" },
                    { 94, "Latvia" },
                    { 95, "Lebanon" },
                    { 96, "Lesotho" },
                    { 97, "Liberia" },
                    { 98, "Libya" },
                    { 99, "Liechtenstein" },
                    { 100, "Lithuania" },
                    { 101, "Luxembourg" },
                    { 102, "Madagascar" },
                    { 103, "Malawi" },
                    { 104, "Malaysia" },
                    { 105, "Maldives" },
                    { 106, "Mali" },
                    { 107, "Malta" },
                    { 108, "Marshall Islands" },
                    { 109, "Mauritania" },
                    { 110, "Mauritius" },
                    { 111, "Mexico" },
                    { 112, "Micronesia" },
                    { 113, "Moldova" },
                    { 114, "Monaco" },
                    { 115, "Mongolia" },
                    { 116, "Montenegro" },
                    { 117, "Morocco" },
                    { 118, "Mozambique" },
                    { 119, "Myanmar (formerly Burma)" },
                    { 120, "Namibia" },
                    { 121, "Nauru" },
                    { 122, "Nepal" },
                    { 123, "Netherlands" },
                    { 124, "New Zealand" },
                    { 125, "Nicaragua" },
                    { 126, "Niger" }
                });

            migrationBuilder.InsertData(
                schema: "Country",
                table: "tblCountries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 127, "Nigeria" },
                    { 128, "North Korea" },
                    { 129, "North Macedonia" },
                    { 130, "Norway" },
                    { 131, "Oman" },
                    { 132, "Pakistan" },
                    { 133, "Palau" },
                    { 134, "Palestine State" },
                    { 135, "Panama" },
                    { 136, "Papua New Guinea" },
                    { 137, "Paraguay" },
                    { 138, "Peru" },
                    { 139, "Philippines" },
                    { 140, "Poland" },
                    { 141, "Portugal" },
                    { 142, "Qatar" },
                    { 143, "Romania" },
                    { 144, "Russia" },
                    { 145, "Rwanda" },
                    { 146, "Saint Kitts and Nevis" },
                    { 147, "Saint Lucia" },
                    { 148, "Saint Vincent and the Grenadines" },
                    { 149, "Samoa" },
                    { 150, "San Marino" },
                    { 151, "Sao Tome and Principe" },
                    { 152, "Saudi Arabia" },
                    { 153, "Senegal" },
                    { 154, "Serbia" },
                    { 155, "Seychelles" },
                    { 156, "Sierra Leone" },
                    { 157, "Singapore" },
                    { 158, "Slovakia" },
                    { 159, "Slovenia" },
                    { 160, "Solomon Islands" },
                    { 161, "Somalia" },
                    { 162, "South Africa" },
                    { 163, "South Korea" },
                    { 164, "South Sudan" },
                    { 165, "Spain" },
                    { 166, "Sri Lanka" },
                    { 167, "Sudan" },
                    { 168, "Suriname" }
                });

            migrationBuilder.InsertData(
                schema: "Country",
                table: "tblCountries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 169, "Sweden" },
                    { 170, "Switzerland" },
                    { 171, "Syria" },
                    { 172, "Tajikistan" },
                    { 173, "Tanzania" },
                    { 174, "Thailand" },
                    { 175, "Timor-Leste" },
                    { 176, "Togo" },
                    { 177, "Tonga" },
                    { 178, "Trinidad and Tobago" },
                    { 179, "Tunisia" },
                    { 180, "Turkey" },
                    { 181, "Turkmenistan" },
                    { 182, "Tuvalu" },
                    { 183, "Uganda" },
                    { 184, "Ukraine" },
                    { 185, "United Arab Emirates" },
                    { 186, "United Kingdom" },
                    { 187, "United States of America" },
                    { 188, "Uruguay" },
                    { 189, "Uzbekistan" },
                    { 190, "Vanuatu" },
                    { 191, "Venezuela" },
                    { 192, "Vietnam" },
                    { 193, "Yemen" },
                    { 194, "Zambia" },
                    { 195, "Zimbabwe" }
                });

            migrationBuilder.InsertData(
                schema: "Director",
                table: "tblDirectors",
                columns: new[] { "Id", "DateOfBirth", "FirstName", "IsActive", "LastName", "Nationality", "PicturePath" },
                values: new object[,]
                {
                    { 1, new DateTime(1965, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael", "Yes", "Bay", "American", "/images/MichaelBay.png" },
                    { 2, new DateTime(1970, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christopher", "Yes", "Nolan", "English", "/images/ChristopherNolan.png" },
                    { 3, new DateTime(1937, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ridley", "Yes", "Scott", "English", "/images/RidleyScott.png" },
                    { 4, new DateTime(1935, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Woody", "No", "Allen", "American", "/images/WoodyAllen.png" },
                    { 5, new DateTime(1961, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peter", "Yes", "Jackson", "New Zealander", "/images/PeterJackson.png" }
                });

            migrationBuilder.InsertData(
                schema: "Genre",
                table: "tblGenres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Action" },
                    { 2, "Adventure" },
                    { 3, "Animation" },
                    { 4, "Comedy" },
                    { 5, "Devotional" },
                    { 6, "Drama" },
                    { 7, "Hindu mythology" },
                    { 8, "Historical" },
                    { 9, "Horror" },
                    { 10, "Science fiction" }
                });

            migrationBuilder.InsertData(
                schema: "Genre",
                table: "tblGenres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 11, "Western" },
                    { 12, "Other" }
                });

            migrationBuilder.InsertData(
                schema: "User",
                table: "tblUsers",
                columns: new[] { "Id", "Email", "FirstName", "IsActive", "LastName" },
                values: new object[,]
                {
                    { 1, "Nabil_EM@outlook.com", "Nabil", "Yes", "El Moussaoui" },
                    { 2, "Abdelmajid.Amiri@outlook.com", "Abdelmajid", "Yes", "Amiri" },
                    { 3, "Azdine.ElJattari@outlook.com", "Azdine", "No", "El Jattari" },
                    { 4, "Mohamed.Azdad@outlook.com", "Mohamed", "Yes", "Azdad" },
                    { 5, "Mirwahaj.Waez@outlook.com", "Mirwahaj", "No", "Waez" }
                });

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
                column: "CountryId");

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
