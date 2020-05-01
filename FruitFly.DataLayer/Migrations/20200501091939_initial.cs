using Microsoft.EntityFrameworkCore.Migrations;

namespace FruitFly.Repository.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Referencepoints",
                columns: table => new
                {
                    ReferencepointId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<int>(nullable: false),
                    RSSI1 = table.Column<int>(nullable: false),
                    RSSI2 = table.Column<int>(nullable: false),
                    RSSI3 = table.Column<int>(nullable: false),
                    X = table.Column<int>(nullable: false),
                    Y = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referencepoints", x => x.ReferencepointId);
                });

            migrationBuilder.CreateTable(
                name: "Heatmaps",
                columns: table => new
                {
                    HeatmapID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReferencepointId = table.Column<int>(nullable: false),
                    ReferencepointId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heatmaps", x => x.HeatmapID);
                    table.ForeignKey(
                        name: "FK_Heatmaps_Referencepoints_ReferencepointId",
                        column: x => x.ReferencepointId,
                        principalTable: "Referencepoints",
                        principalColumn: "ReferencepointId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Heatmaps_Referencepoints_ReferencepointId1",
                        column: x => x.ReferencepointId1,
                        principalTable: "Referencepoints",
                        principalColumn: "ReferencepointId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Referencepoints",
                columns: new[] { "ReferencepointId", "Category", "RSSI1", "RSSI2", "RSSI3", "X", "Y" },
                values: new object[,]
                {
                    { 1, 1, 32, 17, 82, 1, 1 },
                    { 2, 4, 23, 55, 18, 1, 2 },
                    { 3, 14, 56, 16, 59, 2, 1 },
                    { 4, 8, 91, 87, 22, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Heatmaps",
                columns: new[] { "HeatmapID", "ReferencepointId", "ReferencepointId1" },
                values: new object[,]
                {
                    { 1, 1, null },
                    { 2, 2, null },
                    { 3, 3, null },
                    { 4, 4, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Heatmaps_ReferencepointId",
                table: "Heatmaps",
                column: "ReferencepointId");

            migrationBuilder.CreateIndex(
                name: "IX_Heatmaps_ReferencepointId1",
                table: "Heatmaps",
                column: "ReferencepointId1",
                unique: true,
                filter: "[ReferencepointId1] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Heatmaps");

            migrationBuilder.DropTable(
                name: "Referencepoints");
        }
    }
}
