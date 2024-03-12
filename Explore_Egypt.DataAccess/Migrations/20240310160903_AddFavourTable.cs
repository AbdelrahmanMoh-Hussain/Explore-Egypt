﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Explore_Egypt.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddFavourTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Favours",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LandmarkID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favours", x => new { x.UserId, x.LandmarkID });
                    table.ForeignKey(
                        name: "FK_Favours_Landmarks_LandmarkID",
                        column: x => x.LandmarkID,
                        principalTable: "Landmarks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Favours_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "security",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Favours_LandmarkID",
                table: "Favours",
                column: "LandmarkID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favours");
        }
    }
}
