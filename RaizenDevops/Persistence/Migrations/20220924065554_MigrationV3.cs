using Microsoft.EntityFrameworkCore.Migrations;

namespace RaizenDevops.API.Persistence.Migrations
{
    public partial class MigrationV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Fuels",
                newName: "FuelName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FuelName",
                table: "Fuels",
                newName: "Title");
        }
    }
}
