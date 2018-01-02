using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FamilyAssistant.Migrations
{
    public partial class RemoveKeyBetweenVegetableAndUserAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vegetable_Users_AddedByUserId",
                table: "Vegetable");

            migrationBuilder.DropIndex(
                name: "IX_Vegetable_AddedByUserId",
                table: "Vegetable");

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Vegetable",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vegetable_UserID",
                table: "Vegetable",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Vegetable_Users_UserID",
                table: "Vegetable",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vegetable_Users_UserID",
                table: "Vegetable");

            migrationBuilder.DropIndex(
                name: "IX_Vegetable_UserID",
                table: "Vegetable");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Vegetable");

            migrationBuilder.CreateIndex(
                name: "IX_Vegetable_AddedByUserId",
                table: "Vegetable",
                column: "AddedByUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vegetable_Users_AddedByUserId",
                table: "Vegetable",
                column: "AddedByUserId",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
