using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FamilyAssistant.Migrations
{
    public partial class UpdateInsertLogToTransLog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedByOn",
                table: "Vegetable",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LastUpdatedByUserId",
                table: "Vegetable",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedByOn",
                table: "Meat",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LastUpdatedByUserId",
                table: "Meat",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedByOn",
                table: "EntreeVegetable",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LastUpdatedByUserId",
                table: "EntreeVegetable",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedByOn",
                table: "EntreeMeat",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LastUpdatedByUserId",
                table: "EntreeMeat",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedByOn",
                table: "Entree",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LastUpdatedByUserId",
                table: "Entree",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedByOn",
                table: "BaseOption",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LastUpdatedByUserId",
                table: "BaseOption",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastUpdatedByOn",
                table: "Vegetable");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByUserId",
                table: "Vegetable");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByOn",
                table: "Meat");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByUserId",
                table: "Meat");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByOn",
                table: "EntreeVegetable");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByUserId",
                table: "EntreeVegetable");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByOn",
                table: "EntreeMeat");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByUserId",
                table: "EntreeMeat");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByOn",
                table: "Entree");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByUserId",
                table: "Entree");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByOn",
                table: "BaseOption");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByUserId",
                table: "BaseOption");
        }
    }
}
