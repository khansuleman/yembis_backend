using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace yembisbackend.Migrations
{
    /// <inheritdoc />
    public partial class eindelijk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SpeedLimits",
                columns: table => new
                {
                    LimitID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategorieID = table.Column<int>(type: "int", nullable: false),
                    LocationID = table.Column<int>(type: "int", nullable: false),
                    Snelheidslimiet = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpeedLimits", x => x.LimitID);
                    table.ForeignKey(
                        name: "FK_SpeedLimits_Categories_CategorieID",
                        column: x => x.CategorieID,
                        principalTable: "Categories",
                        principalColumn: "CategorieID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpeedLimits_Locations_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Locations",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SpeedLimits_CategorieID",
                table: "SpeedLimits",
                column: "CategorieID");

            migrationBuilder.CreateIndex(
                name: "IX_SpeedLimits_LocationID",
                table: "SpeedLimits",
                column: "LocationID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpeedLimits");
        }
    }
}
