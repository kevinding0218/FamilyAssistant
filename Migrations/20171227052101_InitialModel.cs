using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FamilyAssistant.Migrations
{
    public partial class InitialModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaseOption",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseOption", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Meat",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddedBy = table.Column<int>(nullable: false),
                    AddedOn = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vegetable",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddedBy = table.Column<int>(nullable: false),
                    AddedOn = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vegetable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entree",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddedBy = table.Column<int>(nullable: false),
                    AddedOn = table.Column<DateTime>(nullable: false),
                    BaseOptionId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entree", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entree_BaseOption_BaseOptionId",
                        column: x => x.BaseOptionId,
                        principalTable: "BaseOption",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EntreeMeat",
                columns: table => new
                {
                    EntreeId = table.Column<int>(nullable: false),
                    MeatId = table.Column<int>(nullable: false),
                    AddedBy = table.Column<int>(nullable: false),
                    AddedOn = table.Column<DateTime>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntreeMeat", x => new { x.EntreeId, x.MeatId });
                    table.ForeignKey(
                        name: "FK_EntreeMeat_Entree_EntreeId",
                        column: x => x.EntreeId,
                        principalTable: "Entree",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EntreeMeat_Meat_MeatId",
                        column: x => x.MeatId,
                        principalTable: "Meat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EntreeVegetable",
                columns: table => new
                {
                    EntreeId = table.Column<int>(nullable: false),
                    VegeId = table.Column<int>(nullable: false),
                    AddedBy = table.Column<int>(nullable: false),
                    AddedOn = table.Column<DateTime>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntreeVegetable", x => new { x.EntreeId, x.VegeId });
                    table.ForeignKey(
                        name: "FK_EntreeVegetable_Entree_EntreeId",
                        column: x => x.EntreeId,
                        principalTable: "Entree",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EntreeVegetable_Vegetable_VegeId",
                        column: x => x.VegeId,
                        principalTable: "Vegetable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Entree_BaseOptionId",
                table: "Entree",
                column: "BaseOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_EntreeMeat_MeatId",
                table: "EntreeMeat",
                column: "MeatId");

            migrationBuilder.CreateIndex(
                name: "IX_EntreeVegetable_VegeId",
                table: "EntreeVegetable",
                column: "VegeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntreeMeat");

            migrationBuilder.DropTable(
                name: "EntreeVegetable");

            migrationBuilder.DropTable(
                name: "Meat");

            migrationBuilder.DropTable(
                name: "Entree");

            migrationBuilder.DropTable(
                name: "Vegetable");

            migrationBuilder.DropTable(
                name: "BaseOption");
        }
    }
}
