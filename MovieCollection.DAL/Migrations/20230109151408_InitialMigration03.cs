using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieCollection.DAL.Migrations
{
    public partial class InitialMigration03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblUsers",
                schema: "User");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "User");

            migrationBuilder.CreateTable(
                name: "tblUsers",
                schema: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    FirstName = table.Column<string>(type: "varchar(25)", nullable: false),
                    IsActive = table.Column<string>(type: "varchar(25)", nullable: false),
                    LastName = table.Column<string>(type: "varchar(25)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUsers", x => x.Id);
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
    }
}
