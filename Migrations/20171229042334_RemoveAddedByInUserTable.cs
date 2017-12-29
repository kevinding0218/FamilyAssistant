using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FamilyAssistant.Migrations
{
    public partial class RemoveAddedByInUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_AddedByUserID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_AddedByUserID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AddedByUID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AddedByUserID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AddedOn",
                table: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AddedByUID",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AddedByUserID",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedOn",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Users_AddedByUserID",
                table: "Users",
                column: "AddedByUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_AddedByUserID",
                table: "Users",
                column: "AddedByUserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
