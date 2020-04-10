﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace FruitFly.Repository.Migrations
{
    public partial class test1 : Migration
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
                    { 1, 6, 92, 75, 92, 54, 57 },
                    { 158, 1, 14, 70, 33, 57, 90 },
                    { 159, 4, 16, 5, 57, 75, 77 },
                    { 160, 8, 53, 55, 35, 32, 21 },
                    { 161, 8, 64, 22, 19, 16, 19 },
                    { 162, 6, 31, 91, 88, 83, 40 },
                    { 163, 9, 67, 29, 4, 13, 39 },
                    { 164, 6, 41, 11, 27, 88, 3 },
                    { 165, 4, 24, 68, 33, 92, 31 },
                    { 166, 2, 22, 15, 9, 49, 23 },
                    { 167, 5, 91, 97, 52, 66, 27 },
                    { 168, 9, 51, 32, 65, 64, 9 },
                    { 169, 5, 82, 40, 17, 70, 90 },
                    { 170, 1, 52, 76, 19, 78, 92 },
                    { 171, 5, 34, 38, 61, 71, 62 },
                    { 172, 3, 84, 18, 6, 50, 21 },
                    { 173, 4, 13, 75, 84, 29, 37 },
                    { 174, 7, 75, 59, 59, 84, 10 },
                    { 175, 9, 1, 52, 25, 99, 97 },
                    { 176, 5, 35, 14, 6, 2, 33 },
                    { 177, 9, 38, 79, 70, 41, 79 },
                    { 178, 9, 43, 32, 20, 75, 57 },
                    { 179, 2, 26, 24, 39, 48, 3 },
                    { 180, 3, 91, 49, 28, 71, 70 },
                    { 181, 1, 99, 85, 21, 59, 16 },
                    { 182, 1, 36, 12, 42, 95, 91 },
                    { 183, 6, 1, 35, 80, 68, 42 },
                    { 184, 7, 71, 26, 94, 10, 73 },
                    { 157, 6, 47, 30, 28, 87, 75 },
                    { 185, 7, 8, 86, 12, 72, 10 },
                    { 156, 8, 43, 11, 79, 84, 73 },
                    { 154, 9, 17, 78, 24, 53, 35 },
                    { 127, 3, 32, 63, 45, 30, 65 },
                    { 128, 1, 46, 75, 85, 17, 78 },
                    { 129, 8, 93, 52, 77, 9, 20 },
                    { 130, 7, 89, 36, 46, 3, 87 },
                    { 131, 7, 75, 78, 38, 52, 10 },
                    { 132, 1, 14, 83, 81, 55, 99 },
                    { 133, 2, 66, 77, 67, 91, 8 },
                    { 134, 7, 37, 79, 76, 56, 75 },
                    { 135, 9, 31, 80, 83, 24, 94 },
                    { 136, 2, 78, 29, 76, 76, 54 },
                    { 137, 8, 71, 94, 66, 81, 4 },
                    { 138, 9, 3, 38, 52, 64, 42 },
                    { 139, 4, 5, 98, 29, 78, 66 },
                    { 140, 1, 92, 20, 3, 44, 22 },
                    { 141, 3, 21, 89, 89, 59, 77 },
                    { 142, 7, 38, 90, 24, 80, 20 },
                    { 143, 2, 2, 56, 76, 82, 53 },
                    { 144, 4, 43, 66, 38, 41, 20 },
                    { 145, 9, 93, 99, 63, 67, 84 },
                    { 146, 4, 83, 28, 73, 37, 60 },
                    { 147, 2, 5, 44, 61, 81, 27 },
                    { 148, 5, 19, 25, 79, 15, 76 },
                    { 149, 1, 33, 11, 66, 66, 1 },
                    { 150, 5, 91, 79, 70, 94, 65 },
                    { 151, 7, 9, 70, 6, 89, 96 },
                    { 152, 9, 40, 65, 96, 62, 77 },
                    { 153, 1, 75, 61, 40, 86, 23 },
                    { 155, 7, 68, 18, 27, 19, 46 },
                    { 186, 8, 61, 66, 9, 60, 41 },
                    { 187, 9, 70, 83, 17, 12, 40 },
                    { 188, 5, 73, 30, 33, 81, 47 },
                    { 221, 4, 95, 14, 5, 65, 81 },
                    { 222, 3, 50, 6, 24, 5, 66 },
                    { 223, 2, 79, 22, 22, 49, 54 },
                    { 224, 9, 3, 32, 34, 39, 24 },
                    { 225, 7, 15, 40, 85, 7, 87 },
                    { 226, 7, 53, 3, 15, 39, 95 },
                    { 227, 3, 41, 25, 3, 10, 96 },
                    { 228, 1, 15, 47, 31, 90, 47 },
                    { 229, 8, 59, 43, 60, 56, 35 },
                    { 230, 7, 2, 56, 90, 31, 50 },
                    { 231, 4, 42, 44, 18, 50, 52 },
                    { 232, 6, 97, 40, 27, 92, 8 },
                    { 233, 3, 88, 93, 36, 33, 25 },
                    { 234, 7, 43, 24, 92, 1, 47 },
                    { 235, 5, 14, 96, 68, 45, 38 },
                    { 236, 4, 39, 11, 75, 61, 67 },
                    { 237, 5, 83, 65, 95, 67, 93 },
                    { 238, 1, 58, 67, 36, 32, 68 },
                    { 239, 4, 34, 69, 32, 13, 88 },
                    { 240, 3, 49, 42, 96, 73, 36 },
                    { 241, 5, 95, 52, 3, 88, 53 },
                    { 242, 9, 54, 27, 27, 82, 49 },
                    { 243, 6, 82, 75, 31, 85, 43 },
                    { 244, 8, 9, 82, 29, 27, 12 },
                    { 245, 7, 7, 27, 22, 50, 13 },
                    { 246, 3, 57, 11, 30, 40, 72 },
                    { 247, 4, 5, 70, 15, 39, 77 },
                    { 220, 8, 91, 15, 47, 37, 2 },
                    { 219, 4, 51, 96, 4, 27, 7 },
                    { 218, 5, 89, 83, 37, 47, 7 },
                    { 217, 1, 40, 17, 74, 90, 43 },
                    { 189, 7, 53, 23, 8, 50, 99 },
                    { 190, 5, 16, 90, 12, 47, 52 },
                    { 191, 3, 96, 63, 2, 59, 34 },
                    { 192, 3, 49, 40, 93, 85, 98 },
                    { 193, 6, 61, 59, 85, 48, 36 },
                    { 194, 4, 41, 27, 39, 43, 20 },
                    { 195, 8, 75, 11, 66, 64, 44 },
                    { 196, 5, 83, 23, 31, 87, 16 },
                    { 197, 7, 45, 15, 96, 8, 32 },
                    { 198, 1, 74, 68, 25, 49, 89 },
                    { 199, 4, 59, 68, 54, 68, 6 },
                    { 200, 3, 90, 53, 44, 15, 83 },
                    { 201, 3, 58, 85, 95, 42, 2 },
                    { 126, 1, 88, 4, 95, 84, 58 },
                    { 202, 7, 28, 73, 44, 9, 4 },
                    { 204, 5, 62, 27, 22, 26, 5 },
                    { 205, 7, 97, 16, 17, 6, 97 },
                    { 206, 6, 33, 30, 32, 72, 50 },
                    { 207, 5, 12, 32, 66, 49, 22 },
                    { 208, 2, 97, 51, 64, 33, 21 },
                    { 209, 7, 31, 58, 83, 92, 52 },
                    { 210, 6, 3, 32, 80, 19, 45 },
                    { 211, 8, 59, 22, 76, 80, 76 },
                    { 212, 7, 89, 75, 83, 47, 21 },
                    { 213, 4, 85, 14, 5, 6, 29 },
                    { 214, 5, 13, 64, 94, 44, 74 },
                    { 215, 4, 79, 41, 77, 75, 70 },
                    { 216, 2, 66, 92, 87, 79, 89 },
                    { 203, 2, 47, 33, 94, 32, 69 },
                    { 248, 4, 16, 51, 20, 72, 31 },
                    { 125, 3, 96, 54, 40, 68, 47 },
                    { 123, 1, 68, 40, 78, 32, 77 },
                    { 33, 5, 95, 88, 70, 69, 6 },
                    { 34, 6, 68, 37, 78, 96, 17 },
                    { 35, 7, 16, 12, 29, 88, 43 },
                    { 36, 6, 66, 57, 74, 78, 42 },
                    { 37, 1, 82, 99, 26, 35, 70 },
                    { 38, 9, 34, 76, 1, 68, 70 },
                    { 39, 5, 22, 77, 77, 88, 43 },
                    { 40, 4, 79, 36, 28, 72, 47 },
                    { 41, 6, 53, 70, 21, 78, 63 },
                    { 42, 3, 78, 17, 47, 62, 86 },
                    { 43, 1, 36, 33, 67, 84, 62 },
                    { 44, 4, 70, 48, 41, 74, 66 },
                    { 45, 6, 85, 77, 15, 36, 99 },
                    { 46, 1, 80, 11, 53, 65, 82 },
                    { 47, 9, 73, 55, 14, 76, 89 },
                    { 48, 5, 9, 60, 90, 72, 53 },
                    { 49, 1, 72, 94, 73, 86, 2 },
                    { 50, 9, 20, 79, 4, 55, 93 },
                    { 51, 8, 10, 43, 17, 40, 81 },
                    { 52, 7, 53, 70, 51, 67, 11 },
                    { 53, 1, 27, 93, 58, 87, 65 },
                    { 54, 1, 75, 13, 25, 5, 63 },
                    { 55, 1, 33, 93, 9, 53, 46 },
                    { 56, 1, 95, 19, 62, 29, 66 },
                    { 57, 5, 37, 68, 79, 15, 19 },
                    { 58, 8, 59, 5, 84, 67, 60 },
                    { 59, 1, 41, 32, 14, 97, 79 },
                    { 32, 8, 59, 63, 41, 29, 81 },
                    { 60, 8, 60, 6, 80, 13, 8 },
                    { 31, 6, 32, 45, 44, 62, 72 },
                    { 29, 7, 6, 81, 21, 65, 44 },
                    { 2, 8, 80, 96, 63, 81, 23 },
                    { 3, 9, 6, 16, 82, 4, 46 },
                    { 4, 1, 41, 50, 60, 88, 78 },
                    { 5, 5, 26, 19, 64, 26, 50 },
                    { 6, 1, 21, 46, 79, 57, 39 },
                    { 7, 4, 71, 4, 22, 81, 28 },
                    { 8, 3, 53, 92, 71, 50, 10 },
                    { 9, 7, 67, 10, 63, 3, 19 },
                    { 10, 7, 4, 5, 97, 41, 29 },
                    { 11, 4, 21, 55, 47, 57, 60 },
                    { 12, 7, 21, 48, 76, 39, 33 },
                    { 13, 4, 79, 59, 23, 33, 35 },
                    { 14, 8, 80, 76, 10, 95, 59 },
                    { 15, 4, 43, 19, 27, 9, 54 },
                    { 16, 4, 47, 31, 75, 82, 61 },
                    { 17, 7, 79, 95, 32, 94, 29 },
                    { 18, 6, 92, 28, 77, 20, 23 },
                    { 19, 6, 48, 70, 69, 11, 60 },
                    { 20, 5, 30, 25, 96, 7, 15 },
                    { 21, 4, 50, 12, 94, 42, 92 },
                    { 22, 1, 67, 96, 98, 49, 54 },
                    { 23, 4, 54, 85, 47, 48, 4 },
                    { 24, 3, 63, 23, 95, 67, 61 },
                    { 25, 8, 66, 36, 70, 23, 53 },
                    { 26, 4, 77, 72, 80, 90, 45 },
                    { 27, 2, 67, 50, 36, 74, 53 },
                    { 28, 3, 62, 98, 16, 29, 57 },
                    { 30, 9, 47, 82, 51, 11, 76 },
                    { 61, 8, 67, 99, 24, 47, 71 },
                    { 62, 9, 45, 98, 28, 13, 51 },
                    { 63, 9, 28, 60, 94, 43, 46 },
                    { 96, 4, 70, 98, 73, 58, 33 },
                    { 97, 4, 79, 91, 23, 52, 83 },
                    { 98, 7, 82, 61, 97, 75, 66 },
                    { 99, 4, 57, 37, 26, 84, 21 },
                    { 100, 1, 80, 90, 29, 91, 93 },
                    { 101, 7, 93, 94, 99, 77, 59 },
                    { 102, 6, 69, 57, 89, 94, 38 },
                    { 103, 1, 86, 66, 13, 55, 91 },
                    { 104, 2, 63, 14, 47, 57, 6 },
                    { 105, 8, 13, 86, 78, 70, 77 },
                    { 106, 4, 8, 88, 97, 46, 59 },
                    { 107, 9, 76, 5, 3, 41, 7 },
                    { 108, 1, 48, 62, 99, 21, 97 },
                    { 109, 5, 91, 25, 98, 11, 28 },
                    { 110, 8, 31, 36, 88, 12, 64 },
                    { 111, 7, 78, 98, 79, 48, 87 },
                    { 112, 5, 8, 41, 7, 24, 79 },
                    { 113, 8, 16, 22, 7, 38, 10 },
                    { 114, 4, 88, 92, 88, 24, 79 },
                    { 115, 5, 44, 96, 60, 18, 16 },
                    { 116, 3, 1, 64, 41, 31, 62 },
                    { 117, 1, 30, 99, 75, 49, 14 },
                    { 118, 6, 47, 68, 45, 12, 95 },
                    { 119, 1, 74, 93, 27, 46, 24 },
                    { 120, 7, 83, 54, 20, 27, 4 },
                    { 121, 9, 90, 89, 26, 84, 23 },
                    { 122, 2, 47, 85, 60, 98, 8 },
                    { 95, 6, 88, 13, 94, 62, 25 },
                    { 94, 1, 19, 95, 31, 74, 80 },
                    { 93, 4, 15, 22, 31, 17, 96 },
                    { 92, 8, 56, 24, 17, 29, 55 },
                    { 64, 6, 21, 66, 34, 2, 13 },
                    { 65, 2, 90, 98, 39, 82, 69 },
                    { 66, 6, 66, 25, 61, 91, 47 },
                    { 67, 2, 58, 12, 33, 92, 22 },
                    { 68, 6, 80, 28, 81, 17, 70 },
                    { 69, 2, 86, 18, 59, 22, 91 },
                    { 70, 4, 53, 66, 86, 10, 57 },
                    { 71, 7, 53, 62, 30, 66, 47 },
                    { 72, 3, 36, 36, 14, 74, 84 },
                    { 73, 4, 25, 29, 44, 72, 21 },
                    { 74, 8, 33, 73, 28, 20, 96 },
                    { 75, 5, 2, 44, 33, 20, 39 },
                    { 76, 8, 33, 48, 54, 60, 40 },
                    { 124, 2, 8, 32, 2, 54, 44 },
                    { 77, 6, 32, 15, 81, 55, 80 },
                    { 79, 6, 97, 80, 46, 3, 76 },
                    { 80, 8, 46, 33, 66, 78, 64 },
                    { 81, 1, 93, 17, 97, 33, 42 },
                    { 82, 4, 80, 65, 89, 84, 41 },
                    { 83, 1, 4, 78, 93, 93, 15 },
                    { 84, 8, 19, 76, 48, 70, 23 },
                    { 85, 6, 35, 30, 72, 70, 14 },
                    { 86, 1, 94, 54, 50, 79, 62 },
                    { 87, 6, 38, 72, 69, 96, 46 },
                    { 88, 3, 73, 14, 40, 39, 99 },
                    { 89, 9, 90, 53, 18, 81, 59 },
                    { 90, 8, 54, 23, 93, 39, 98 },
                    { 91, 2, 64, 10, 52, 82, 90 },
                    { 78, 4, 6, 12, 33, 26, 96 },
                    { 249, 2, 94, 63, 99, 16, 64 }
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
