using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FamilyAssistant.Migrations
{
    public partial class AddTableIngredient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ingredient",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddedByUserId = table.Column<int>(nullable: false),
                    AddedOn = table.Column<DateTime>(nullable: false),
                    LastUpdatedByOn = table.Column<DateTime>(nullable: true),
                    LastUpdatedByUserId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Note = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredient", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EntreeIngredient",
                columns: table => new
                {
                    EntreeId = table.Column<int>(nullable: false),
                    IngredientId = table.Column<int>(nullable: false),
                    AddedByUserId = table.Column<int>(nullable: false),
                    AddedOn = table.Column<DateTime>(nullable: false),
                    LastUpdatedByOn = table.Column<DateTime>(nullable: true),
                    LastUpdatedByUserId = table.Column<int>(nullable: true),
                    Note = table.Column<string>(maxLength: 255, nullable: true),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntreeIngredient", x => new { x.EntreeId, x.IngredientId });
                    table.ForeignKey(
                        name: "FK_EntreeIngredient_Entree_EntreeId",
                        column: x => x.EntreeId,
                        principalTable: "Entree",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EntreeIngredient_Ingredient_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EntreeIngredient_IngredientId",
                table: "EntreeIngredient",
                column: "IngredientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntreeIngredient");

            migrationBuilder.DropTable(
                name: "Ingredient");
        }
    }
}
