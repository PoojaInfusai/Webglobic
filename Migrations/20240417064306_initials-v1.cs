using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webglobic.Migrations
{
    /// <inheritdoc />
    public partial class initialsv1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CountryNameId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Users_CountryNameId",
                table: "Users",
                column: "CountryNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Country_CountryNameId",
                table: "Users",
                column: "CountryNameId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Country_CountryNameId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CountryNameId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CountryNameId",
                table: "Users");
        }
    }
}
