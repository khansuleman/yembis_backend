using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace yembisbackend.Migrations
{
    public partial class idkman3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Locations_CameraID",
                table: "Locations",
                column: "CameraID");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Cameras_CameraID",
                table: "Locations",
                column: "CameraID",
                principalTable: "Cameras",
                principalColumn: "CameraID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Cameras_CameraID",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Locations_CameraID",
                table: "Locations");
        }
    }
}
