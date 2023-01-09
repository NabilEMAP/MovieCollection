using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieCollection.DAL.Migrations
{
    public partial class Stp_GetCountryByName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE [dbo].[GetCountryByName]
                     @countryName nvarchar(255)
            AS
            BEGIN
                SET NOCOUNT ON;
                SELECT * FROM [MovieCollection].[Country].[tblCountries] c
                WHERE c.Name like '%@countryName%'
            END";

            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
