using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FamilyAssistant.Migrations
{
    public partial class RemoveKeyBetweenVegetableAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vegetable_Users_AddedByUserID",
                table: "Vegetable");

            migrationBuilder.RenameColumn(
                name: "AddedByUserID",
                table: "Vegetable",
                newName: "AddedByUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Vegetable_AddedByUserID",
                table: "Vegetable",
                newName: "IX_Vegetable_AddedByUserId");

            migrationBuilder.AlterColumn<int>(
                name: "AddedByUserId",
                table: "Vegetable",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Vegetable_Users_AddedByUserId",
                table: "Vegetable",
                column: "AddedByUserId",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vegetable_Users_AddedByUserId",
                table: "Vegetable");

            migrationBuilder.RenameColumn(
                name: "AddedByUserId",
                table: "Vegetable",
                newName: "AddedByUserID");

            migrationBuilder.RenameIndex(
                name: "IX_Vegetable_AddedByUserId",
                table: "Vegetable",
                newName: "IX_Vegetable_AddedByUserID");

            migrationBuilder.AlterColumn<int>(
                name: "AddedByUserID",
                table: "Vegetable",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Vegetable_Users_AddedByUserID",
                table: "Vegetable",
                column: "AddedByUserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
