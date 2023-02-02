using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace yembisbackend.Migrations
{
    public partial class donderdag2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Metings_Cameras_CameraID",
                table: "Metings");

            migrationBuilder.DropForeignKey(
                name: "FK_Metings_Categories_CategorieID",
                table: "Metings");

            migrationBuilder.DropIndex(
                name: "IX_Metings_CameraID",
                table: "Metings");

            migrationBuilder.DropIndex(
                name: "IX_Metings_CategorieID",
                table: "Metings");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Metings_CameraID",
                table: "Metings",
                column: "CameraID");

            migrationBuilder.CreateIndex(
                name: "IX_Metings_CategorieID",
                table: "Metings",
                column: "CategorieID");

            migrationBuilder.AddForeignKey(
                name: "FK_Metings_Cameras_CameraID",
                table: "Metings",
                column: "CameraID",
                principalTable: "Cameras",
                principalColumn: "CameraID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Metings_Categories_CategorieID",
                table: "Metings",
                column: "CategorieID",
                principalTable: "Categories",
                principalColumn: "CategorieID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
