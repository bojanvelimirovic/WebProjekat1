using Microsoft.EntityFrameworkCore.Migrations;

namespace Server.Migrations
{
    public partial class V3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tip",
                table: "Lokacija",
                newName: "Ime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ime",
                table: "Lokacija",
                newName: "Tip");
        }
    }
}
