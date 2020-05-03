﻿using Microsoft.EntityFrameworkCore.Migrations;

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
                    ReferencepointId = table.Column<int>(nullable: false)
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
                });

            migrationBuilder.InsertData(
                table: "Referencepoints",
                columns: new[] { "ReferencepointId", "Category", "RSSI1", "RSSI2", "RSSI3", "X", "Y" },
                values: new object[,]
                {
                    { 1, 6, 70, 11, 89, 72, 91 },
                    { 158, 8, 56, 43, 71, 61, 98 },
                    { 159, 1, 61, 69, 68, 80, 91 },
                    { 160, 4, 6, 35, 47, 35, 71 },
                    { 161, 6, 86, 15, 60, 78, 96 },
                    { 162, 1, 20, 3, 6, 93, 31 },
                    { 163, 3, 93, 31, 24, 99, 97 },
                    { 164, 2, 22, 26, 25, 52, 61 },
                    { 165, 4, 38, 98, 83, 78, 19 },
                    { 166, 8, 18, 52, 74, 66, 11 },
                    { 167, 8, 21, 77, 46, 69, 41 },
                    { 168, 9, 99, 68, 39, 39, 87 },
                    { 169, 6, 19, 6, 37, 30, 13 },
                    { 170, 5, 38, 35, 54, 20, 41 },
                    { 171, 9, 19, 41, 83, 23, 75 },
                    { 172, 8, 55, 28, 21, 41, 78 },
                    { 173, 2, 70, 52, 84, 28, 53 },
                    { 174, 9, 2, 99, 12, 24, 60 },
                    { 175, 2, 46, 87, 39, 29, 29 },
                    { 176, 7, 29, 1, 37, 48, 50 },
                    { 177, 9, 14, 76, 92, 60, 83 },
                    { 178, 6, 39, 78, 27, 17, 60 },
                    { 179, 6, 61, 10, 81, 61, 19 },
                    { 180, 4, 86, 95, 81, 70, 77 },
                    { 181, 8, 40, 27, 98, 45, 12 },
                    { 182, 8, 83, 22, 3, 84, 15 },
                    { 183, 7, 1, 42, 17, 52, 85 },
                    { 184, 8, 86, 29, 28, 78, 68 },
                    { 157, 6, 86, 46, 29, 97, 98 },
                    { 185, 2, 94, 67, 82, 96, 62 },
                    { 156, 1, 79, 75, 21, 25, 17 },
                    { 154, 2, 29, 22, 80, 53, 59 },
                    { 127, 5, 58, 12, 40, 78, 38 },
                    { 128, 1, 20, 42, 31, 45, 9 },
                    { 129, 1, 96, 40, 91, 16, 15 },
                    { 130, 9, 32, 83, 97, 87, 57 },
                    { 131, 7, 61, 27, 68, 30, 30 },
                    { 132, 6, 24, 26, 93, 68, 53 },
                    { 133, 4, 33, 64, 46, 64, 69 },
                    { 134, 8, 12, 80, 55, 34, 65 },
                    { 135, 2, 82, 13, 31, 84, 37 },
                    { 136, 7, 50, 70, 55, 63, 17 },
                    { 137, 1, 37, 90, 13, 75, 22 },
                    { 138, 8, 8, 28, 87, 53, 82 },
                    { 139, 5, 49, 68, 15, 19, 76 },
                    { 140, 7, 22, 28, 62, 54, 48 },
                    { 141, 2, 25, 39, 88, 22, 18 },
                    { 142, 8, 83, 69, 47, 35, 27 },
                    { 143, 8, 66, 36, 58, 72, 26 },
                    { 144, 4, 27, 29, 30, 80, 36 },
                    { 145, 7, 57, 32, 94, 77, 42 },
                    { 146, 8, 49, 83, 42, 96, 51 },
                    { 147, 8, 94, 85, 11, 6, 70 },
                    { 148, 2, 5, 14, 41, 36, 52 },
                    { 149, 4, 19, 49, 2, 26, 27 },
                    { 150, 2, 86, 45, 3, 20, 64 },
                    { 151, 8, 88, 6, 27, 58, 85 },
                    { 152, 4, 37, 70, 84, 76, 77 },
                    { 153, 4, 27, 22, 58, 17, 76 },
                    { 155, 9, 86, 24, 57, 22, 10 },
                    { 186, 5, 19, 44, 99, 5, 20 },
                    { 187, 6, 61, 93, 66, 49, 34 },
                    { 188, 4, 58, 76, 94, 5, 60 },
                    { 221, 9, 66, 74, 68, 76, 88 },
                    { 222, 1, 10, 37, 3, 56, 63 },
                    { 223, 1, 8, 16, 59, 75, 8 },
                    { 224, 4, 28, 36, 21, 1, 9 },
                    { 225, 8, 64, 37, 60, 87, 81 },
                    { 226, 4, 12, 60, 38, 90, 30 },
                    { 227, 5, 99, 88, 52, 58, 75 },
                    { 228, 6, 94, 65, 7, 39, 28 },
                    { 229, 5, 1, 13, 6, 49, 92 },
                    { 230, 7, 75, 66, 66, 89, 13 },
                    { 231, 5, 44, 23, 56, 66, 44 },
                    { 232, 1, 72, 18, 85, 7, 76 },
                    { 233, 2, 87, 70, 60, 56, 7 },
                    { 234, 4, 72, 25, 9, 6, 86 },
                    { 235, 7, 31, 62, 67, 71, 15 },
                    { 236, 6, 86, 11, 75, 1, 14 },
                    { 237, 5, 10, 29, 22, 4, 67 },
                    { 238, 1, 68, 94, 37, 86, 62 },
                    { 239, 3, 7, 20, 60, 23, 17 },
                    { 240, 8, 43, 38, 36, 87, 35 },
                    { 241, 8, 36, 2, 3, 22, 20 },
                    { 242, 6, 43, 86, 56, 9, 47 },
                    { 243, 7, 22, 68, 57, 98, 38 },
                    { 244, 9, 32, 44, 1, 45, 64 },
                    { 245, 9, 4, 63, 93, 87, 57 },
                    { 246, 7, 17, 22, 93, 40, 67 },
                    { 247, 6, 8, 46, 75, 71, 43 },
                    { 220, 6, 88, 13, 89, 21, 3 },
                    { 219, 9, 21, 70, 49, 36, 69 },
                    { 218, 7, 65, 40, 61, 84, 2 },
                    { 217, 1, 80, 40, 85, 96, 27 },
                    { 189, 7, 25, 35, 11, 99, 84 },
                    { 190, 5, 60, 62, 59, 79, 51 },
                    { 191, 5, 96, 87, 60, 48, 66 },
                    { 192, 7, 77, 96, 22, 60, 91 },
                    { 193, 9, 16, 37, 95, 89, 21 },
                    { 194, 9, 25, 89, 7, 6, 71 },
                    { 195, 3, 45, 19, 59, 51, 44 },
                    { 196, 6, 97, 81, 42, 22, 53 },
                    { 197, 5, 78, 10, 11, 24, 28 },
                    { 198, 6, 56, 64, 43, 19, 84 },
                    { 199, 5, 53, 71, 41, 67, 55 },
                    { 200, 6, 38, 91, 16, 33, 4 },
                    { 201, 5, 12, 27, 53, 63, 63 },
                    { 126, 7, 29, 46, 79, 69, 56 },
                    { 202, 1, 49, 93, 84, 49, 11 },
                    { 204, 1, 84, 26, 34, 13, 97 },
                    { 205, 7, 17, 31, 26, 80, 83 },
                    { 206, 6, 31, 46, 7, 63, 12 },
                    { 207, 1, 11, 92, 2, 33, 69 },
                    { 208, 9, 63, 5, 61, 31, 86 },
                    { 209, 5, 1, 94, 42, 8, 48 },
                    { 210, 7, 14, 99, 29, 81, 46 },
                    { 211, 3, 84, 69, 11, 23, 19 },
                    { 212, 6, 4, 18, 89, 60, 33 },
                    { 213, 6, 7, 51, 56, 44, 50 },
                    { 214, 9, 12, 86, 44, 72, 80 },
                    { 215, 9, 20, 23, 97, 29, 49 },
                    { 216, 2, 72, 30, 47, 69, 49 },
                    { 203, 1, 81, 2, 61, 43, 50 },
                    { 248, 7, 66, 98, 73, 82, 2 },
                    { 125, 4, 26, 63, 34, 61, 54 },
                    { 123, 1, 94, 49, 16, 11, 50 },
                    { 33, 9, 19, 45, 7, 40, 29 },
                    { 34, 2, 34, 18, 13, 45, 97 },
                    { 35, 9, 97, 16, 91, 22, 81 },
                    { 36, 7, 36, 41, 80, 76, 54 },
                    { 37, 7, 8, 56, 62, 17, 89 },
                    { 38, 7, 22, 41, 31, 20, 95 },
                    { 39, 7, 25, 39, 91, 70, 63 },
                    { 40, 2, 33, 89, 59, 80, 18 },
                    { 41, 1, 77, 74, 9, 58, 3 },
                    { 42, 8, 16, 43, 90, 33, 32 },
                    { 43, 7, 58, 18, 28, 46, 23 },
                    { 44, 6, 63, 77, 21, 23, 96 },
                    { 45, 4, 82, 66, 77, 59, 44 },
                    { 46, 6, 15, 28, 38, 56, 40 },
                    { 47, 2, 59, 63, 38, 51, 5 },
                    { 48, 5, 78, 91, 7, 18, 13 },
                    { 49, 5, 93, 86, 66, 4, 17 },
                    { 50, 4, 86, 54, 77, 65, 75 },
                    { 51, 4, 3, 57, 99, 26, 19 },
                    { 52, 1, 35, 2, 77, 12, 87 },
                    { 53, 6, 18, 12, 73, 68, 45 },
                    { 54, 1, 36, 65, 54, 32, 65 },
                    { 55, 6, 98, 12, 11, 98, 70 },
                    { 56, 8, 39, 93, 87, 2, 48 },
                    { 57, 5, 53, 52, 73, 3, 82 },
                    { 58, 1, 68, 82, 99, 7, 85 },
                    { 59, 1, 67, 18, 9, 72, 29 },
                    { 32, 7, 95, 89, 33, 38, 21 },
                    { 60, 1, 83, 71, 91, 42, 27 },
                    { 31, 5, 34, 57, 74, 15, 22 },
                    { 29, 5, 79, 52, 16, 14, 14 },
                    { 2, 2, 28, 86, 89, 30, 87 },
                    { 3, 5, 60, 18, 77, 10, 4 },
                    { 4, 6, 19, 47, 78, 65, 95 },
                    { 5, 7, 43, 66, 10, 98, 85 },
                    { 6, 2, 5, 69, 11, 63, 41 },
                    { 7, 9, 98, 50, 81, 47, 13 },
                    { 8, 5, 93, 86, 31, 57, 52 },
                    { 9, 4, 24, 32, 18, 79, 71 },
                    { 10, 7, 85, 6, 15, 20, 30 },
                    { 11, 3, 4, 29, 1, 71, 26 },
                    { 12, 2, 36, 96, 76, 88, 12 },
                    { 13, 5, 76, 72, 35, 26, 71 },
                    { 14, 1, 39, 85, 15, 73, 75 },
                    { 15, 5, 2, 25, 98, 40, 78 },
                    { 16, 4, 74, 79, 21, 56, 44 },
                    { 17, 8, 52, 23, 60, 13, 22 },
                    { 18, 6, 59, 35, 21, 64, 3 },
                    { 19, 9, 36, 59, 34, 6, 80 },
                    { 20, 4, 11, 30, 54, 47, 69 },
                    { 21, 1, 20, 95, 18, 41, 14 },
                    { 22, 3, 33, 21, 29, 51, 74 },
                    { 23, 5, 49, 26, 64, 59, 15 },
                    { 24, 4, 33, 38, 23, 99, 5 },
                    { 25, 2, 3, 69, 98, 76, 46 },
                    { 26, 2, 30, 6, 53, 60, 93 },
                    { 27, 3, 38, 19, 21, 88, 31 },
                    { 28, 8, 70, 84, 85, 85, 56 },
                    { 30, 3, 78, 20, 90, 97, 39 },
                    { 61, 1, 93, 37, 32, 91, 73 },
                    { 62, 9, 72, 17, 64, 26, 15 },
                    { 63, 9, 32, 34, 82, 43, 63 },
                    { 96, 4, 5, 79, 59, 20, 11 },
                    { 97, 9, 13, 98, 34, 92, 42 },
                    { 98, 3, 56, 93, 75, 28, 23 },
                    { 99, 3, 27, 54, 47, 13, 86 },
                    { 100, 3, 48, 15, 36, 58, 3 },
                    { 101, 2, 12, 8, 20, 87, 40 },
                    { 102, 7, 73, 46, 82, 55, 40 },
                    { 103, 4, 19, 37, 40, 93, 29 },
                    { 104, 8, 17, 28, 82, 4, 38 },
                    { 105, 9, 92, 91, 92, 35, 71 },
                    { 106, 9, 54, 54, 96, 14, 81 },
                    { 107, 4, 13, 68, 53, 98, 54 },
                    { 108, 7, 44, 72, 14, 9, 93 },
                    { 109, 5, 84, 55, 86, 56, 42 },
                    { 110, 7, 38, 8, 69, 28, 95 },
                    { 111, 5, 84, 39, 74, 87, 1 },
                    { 112, 8, 42, 6, 56, 6, 80 },
                    { 113, 6, 28, 18, 74, 5, 59 },
                    { 114, 6, 78, 83, 98, 43, 51 },
                    { 115, 2, 10, 98, 13, 22, 75 },
                    { 116, 7, 66, 84, 73, 5, 15 },
                    { 117, 2, 4, 57, 71, 29, 67 },
                    { 118, 8, 93, 78, 74, 26, 29 },
                    { 119, 3, 1, 33, 48, 3, 50 },
                    { 120, 2, 50, 41, 87, 57, 77 },
                    { 121, 1, 73, 20, 30, 82, 39 },
                    { 122, 9, 87, 23, 4, 58, 2 },
                    { 95, 9, 56, 5, 30, 65, 46 },
                    { 94, 5, 30, 82, 26, 84, 74 },
                    { 93, 3, 65, 92, 45, 52, 37 },
                    { 92, 4, 72, 66, 27, 44, 55 },
                    { 64, 8, 58, 92, 27, 6, 32 },
                    { 65, 5, 77, 66, 64, 77, 18 },
                    { 66, 7, 56, 11, 25, 66, 9 },
                    { 67, 5, 78, 77, 9, 6, 35 },
                    { 68, 7, 41, 41, 4, 16, 41 },
                    { 69, 9, 28, 40, 9, 8, 84 },
                    { 70, 4, 80, 88, 6, 80, 14 },
                    { 71, 1, 29, 95, 98, 86, 69 },
                    { 72, 1, 68, 65, 25, 37, 64 },
                    { 73, 8, 74, 52, 57, 58, 64 },
                    { 74, 9, 49, 62, 26, 69, 49 },
                    { 75, 7, 68, 48, 27, 90, 85 },
                    { 76, 2, 40, 98, 63, 3, 76 },
                    { 124, 7, 42, 83, 70, 89, 22 },
                    { 77, 4, 69, 55, 72, 99, 48 },
                    { 79, 3, 77, 23, 24, 16, 32 },
                    { 80, 5, 80, 60, 46, 21, 18 },
                    { 81, 2, 77, 78, 80, 4, 97 },
                    { 82, 6, 22, 71, 75, 19, 89 },
                    { 83, 1, 18, 49, 14, 51, 99 },
                    { 84, 6, 3, 46, 15, 93, 13 },
                    { 85, 6, 97, 24, 67, 12, 22 },
                    { 86, 2, 93, 48, 37, 52, 23 },
                    { 87, 7, 95, 66, 93, 10, 1 },
                    { 88, 6, 57, 59, 34, 15, 98 },
                    { 89, 8, 38, 30, 61, 88, 19 },
                    { 90, 7, 7, 83, 65, 17, 7 },
                    { 91, 7, 99, 11, 50, 58, 26 },
                    { 78, 7, 70, 90, 75, 23, 34 },
                    { 249, 5, 32, 45, 1, 43, 55 }
                });

            migrationBuilder.InsertData(
                table: "Heatmaps",
                columns: new[] { "HeatmapID", "ReferencepointId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 158, 158 },
                    { 159, 159 },
                    { 160, 160 },
                    { 161, 161 },
                    { 162, 162 },
                    { 163, 163 },
                    { 164, 164 },
                    { 165, 165 },
                    { 166, 166 },
                    { 167, 167 },
                    { 168, 168 },
                    { 169, 169 },
                    { 170, 170 },
                    { 171, 171 },
                    { 172, 172 },
                    { 173, 173 },
                    { 174, 174 },
                    { 175, 175 },
                    { 176, 176 },
                    { 177, 177 },
                    { 178, 178 },
                    { 179, 179 },
                    { 180, 180 },
                    { 181, 181 },
                    { 182, 182 },
                    { 183, 183 },
                    { 184, 184 },
                    { 157, 157 },
                    { 185, 185 },
                    { 156, 156 },
                    { 154, 154 },
                    { 127, 127 },
                    { 128, 128 },
                    { 129, 129 },
                    { 130, 130 },
                    { 131, 131 },
                    { 132, 132 },
                    { 133, 133 },
                    { 134, 134 },
                    { 135, 135 },
                    { 136, 136 },
                    { 137, 137 },
                    { 138, 138 },
                    { 139, 139 },
                    { 140, 140 },
                    { 141, 141 },
                    { 142, 142 },
                    { 143, 143 },
                    { 144, 144 },
                    { 145, 145 },
                    { 146, 146 },
                    { 147, 147 },
                    { 148, 148 },
                    { 149, 149 },
                    { 150, 150 },
                    { 151, 151 },
                    { 152, 152 },
                    { 153, 153 },
                    { 155, 155 },
                    { 186, 186 },
                    { 187, 187 },
                    { 188, 188 },
                    { 221, 221 },
                    { 222, 222 },
                    { 223, 223 },
                    { 224, 224 },
                    { 225, 225 },
                    { 226, 226 },
                    { 227, 227 },
                    { 228, 228 },
                    { 229, 229 },
                    { 230, 230 },
                    { 231, 231 },
                    { 232, 232 },
                    { 233, 233 },
                    { 234, 234 },
                    { 235, 235 },
                    { 236, 236 },
                    { 237, 237 },
                    { 238, 238 },
                    { 239, 239 },
                    { 240, 240 },
                    { 241, 241 },
                    { 242, 242 },
                    { 243, 243 },
                    { 244, 244 },
                    { 245, 245 },
                    { 246, 246 },
                    { 247, 247 },
                    { 220, 220 },
                    { 219, 219 },
                    { 218, 218 },
                    { 217, 217 },
                    { 189, 189 },
                    { 190, 190 },
                    { 191, 191 },
                    { 192, 192 },
                    { 193, 193 },
                    { 194, 194 },
                    { 195, 195 },
                    { 196, 196 },
                    { 197, 197 },
                    { 198, 198 },
                    { 199, 199 },
                    { 200, 200 },
                    { 201, 201 },
                    { 126, 126 },
                    { 202, 202 },
                    { 204, 204 },
                    { 205, 205 },
                    { 206, 206 },
                    { 207, 207 },
                    { 208, 208 },
                    { 209, 209 },
                    { 210, 210 },
                    { 211, 211 },
                    { 212, 212 },
                    { 213, 213 },
                    { 214, 214 },
                    { 215, 215 },
                    { 216, 216 },
                    { 203, 203 },
                    { 248, 248 },
                    { 125, 125 },
                    { 123, 123 },
                    { 33, 33 },
                    { 34, 34 },
                    { 35, 35 },
                    { 36, 36 },
                    { 37, 37 },
                    { 38, 38 },
                    { 39, 39 },
                    { 40, 40 },
                    { 41, 41 },
                    { 42, 42 },
                    { 43, 43 },
                    { 44, 44 },
                    { 45, 45 },
                    { 46, 46 },
                    { 47, 47 },
                    { 48, 48 },
                    { 49, 49 },
                    { 50, 50 },
                    { 51, 51 },
                    { 52, 52 },
                    { 53, 53 },
                    { 54, 54 },
                    { 55, 55 },
                    { 56, 56 },
                    { 57, 57 },
                    { 58, 58 },
                    { 59, 59 },
                    { 32, 32 },
                    { 60, 60 },
                    { 31, 31 },
                    { 29, 29 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 7 },
                    { 8, 8 },
                    { 9, 9 },
                    { 10, 10 },
                    { 11, 11 },
                    { 12, 12 },
                    { 13, 13 },
                    { 14, 14 },
                    { 15, 15 },
                    { 16, 16 },
                    { 17, 17 },
                    { 18, 18 },
                    { 19, 19 },
                    { 20, 20 },
                    { 21, 21 },
                    { 22, 22 },
                    { 23, 23 },
                    { 24, 24 },
                    { 25, 25 },
                    { 26, 26 },
                    { 27, 27 },
                    { 28, 28 },
                    { 30, 30 },
                    { 61, 61 },
                    { 62, 62 },
                    { 63, 63 },
                    { 96, 96 },
                    { 97, 97 },
                    { 98, 98 },
                    { 99, 99 },
                    { 100, 100 },
                    { 101, 101 },
                    { 102, 102 },
                    { 103, 103 },
                    { 104, 104 },
                    { 105, 105 },
                    { 106, 106 },
                    { 107, 107 },
                    { 108, 108 },
                    { 109, 109 },
                    { 110, 110 },
                    { 111, 111 },
                    { 112, 112 },
                    { 113, 113 },
                    { 114, 114 },
                    { 115, 115 },
                    { 116, 116 },
                    { 117, 117 },
                    { 118, 118 },
                    { 119, 119 },
                    { 120, 120 },
                    { 121, 121 },
                    { 122, 122 },
                    { 95, 95 },
                    { 94, 94 },
                    { 93, 93 },
                    { 92, 92 },
                    { 64, 64 },
                    { 65, 65 },
                    { 66, 66 },
                    { 67, 67 },
                    { 68, 68 },
                    { 69, 69 },
                    { 70, 70 },
                    { 71, 71 },
                    { 72, 72 },
                    { 73, 73 },
                    { 74, 74 },
                    { 75, 75 },
                    { 76, 76 },
                    { 124, 124 },
                    { 77, 77 },
                    { 79, 79 },
                    { 80, 80 },
                    { 81, 81 },
                    { 82, 82 },
                    { 83, 83 },
                    { 84, 84 },
                    { 85, 85 },
                    { 86, 86 },
                    { 87, 87 },
                    { 88, 88 },
                    { 89, 89 },
                    { 90, 90 },
                    { 91, 91 },
                    { 78, 78 },
                    { 249, 249 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Heatmaps_ReferencepointId",
                table: "Heatmaps",
                column: "ReferencepointId",
                unique: true);
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
