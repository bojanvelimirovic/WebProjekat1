using Microsoft.EntityFrameworkCore.Migrations;

namespace Server.Migrations
{
    public partial class V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lokacija_Avion_AvionID",
                table: "Lokacija");

            migrationBuilder.AddForeignKey(
                name: "FK_Lokacija_Avion_AvionID",
                table: "Lokacija",
                column: "AvionID",
                principalTable: "Avion",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lokacija_Avion_AvionID",
                table: "Lokacija");

            migrationBuilder.AddForeignKey(
                name: "FK_Lokacija_Avion_AvionID",
                table: "Lokacija",
                column: "AvionID",
                principalTable: "Avion",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
