using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FamilyAssistant.Migrations
{
    public partial class RemoveAddedByUID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vegetable_Users_AddedByUID",
                table: "Vegetable");

            migrationBuilder.DropColumn(
                name: "AddedByUID",
                table: "Meat");

            migrationBuilder.DropColumn(
                name: "AddedByUID",
                table: "EntreeVegetable");

            migrationBuilder.DropColumn(
                name: "AddedByUID",
                table: "EntreeMeat");

            migrationBuilder.DropColumn(
                name: "AddedByUID",
                table: "Entree");

            migrationBuilder.DropColumn(
                name: "AddedByUID",
                table: "BaseOption");

            migrationBuilder.RenameColumn(
                name: "AddedByUID",
                table: "Vegetable",
                newName: "AddedByUserID");

            migrationBuilder.RenameIndex(
                name: "IX_Vegetable_AddedByUID",
                table: "Vegetable",
                newName: "IX_Vegetable_AddedByUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Vegetable_Users_AddedByUserID",
                table: "Vegetable",
                column: "AddedByUserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vegetable_Users_AddedByUserID",
                table: "Vegetable");

            migrationBuilder.RenameColumn(
                name: "AddedByUserID",
                table: "Vegetable",
                newName: "AddedByUID");

            migrationBuilder.RenameIndex(
                name: "IX_Vegetable_AddedByUserID",
                table: "Vegetable",
                newName: "IX_Vegetable_AddedByUID");

            migrationBuilder.AddColumn<int>(
                name: "AddedByUID",
                table: "Meat",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AddedByUID",
                table: "EntreeVegetable",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AddedByUID",
                table: "EntreeMeat",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AddedByUID",
                table: "Entree",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AddedByUID",
                table: "BaseOption",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Vegetable_Users_AddedByUID",
                table: "Vegetable",
                column: "AddedByUID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
