using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FamilyAssistant.Migrations
{
    public partial class ReInitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactAddress",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddedByUserId = table.Column<int>(nullable: false),
                    AddedOn = table.Column<DateTime>(nullable: false),
                    Address1 = table.Column<string>(nullable: true),
                    Address2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    LastUpdatedByOn = table.Column<DateTime>(nullable: true),
                    LastUpdatedByUserId = table.Column<int>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    ZipCode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactAddress", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MealTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Meat",
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
                    table.PrimaryKey("PK_Meat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StapleFood",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddedByUserId = table.Column<int>(nullable: false),
                    AddedOn = table.Column<DateTime>(nullable: false),
                    LastUpdatedByOn = table.Column<DateTime>(nullable: true),
                    LastUpdatedByUserId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    Note = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StapleFood", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddedByUserId = table.Column<int>(nullable: false),
                    AddedOn = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: false),
                    FirstName = table.Column<string>(maxLength: 30, nullable: true),
                    IsFAUser = table.Column<bool>(nullable: true),
                    LastLogIn = table.Column<DateTime>(nullable: false),
                    LastName = table.Column<string>(maxLength: 30, nullable: true),
                    LastUpdatedByOn = table.Column<DateTime>(nullable: true),
                    LastUpdatedByUserId = table.Column<int>(nullable: true),
                    Note = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Vegetable",
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
                    table.PrimaryKey("PK_Vegetable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Supermarket",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddedByUserId = table.Column<int>(nullable: false),
                    AddedOn = table.Column<DateTime>(nullable: false),
                    AddressRefId = table.Column<int>(nullable: false),
                    LastUpdatedByOn = table.Column<DateTime>(nullable: true),
                    LastUpdatedByUserId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Note = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supermarket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Supermarket_ContactAddress_AddressRefId",
                        column: x => x.AddressRefId,
                        principalTable: "ContactAddress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Entree",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddedByUserId = table.Column<int>(nullable: false),
                    AddedOn = table.Column<DateTime>(nullable: false),
                    CurrentRank = table.Column<int>(nullable: true),
                    LastUpdatedByOn = table.Column<DateTime>(nullable: true),
                    LastUpdatedByUserId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Note = table.Column<string>(maxLength: 255, nullable: true),
                    StapleFoodId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entree", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entree_StapleFood_StapleFoodId",
                        column: x => x.StapleFoodId,
                        principalTable: "StapleFood",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupermarketMeat",
                columns: table => new
                {
                    SupermarketId = table.Column<int>(nullable: false),
                    MeatId = table.Column<int>(nullable: false),
                    AddedByUserId = table.Column<int>(nullable: false),
                    AddedOn = table.Column<DateTime>(nullable: false),
                    LastUpdatedByOn = table.Column<DateTime>(nullable: true),
                    LastUpdatedByUserId = table.Column<int>(nullable: true),
                    Note = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupermarketMeat", x => new { x.SupermarketId, x.MeatId });
                    table.ForeignKey(
                        name: "FK_SupermarketMeat_Meat_MeatId",
                        column: x => x.MeatId,
                        principalTable: "Meat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupermarketMeat_Supermarket_SupermarketId",
                        column: x => x.SupermarketId,
                        principalTable: "Supermarket",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupermarketStapleFood",
                columns: table => new
                {
                    SuperMarketId = table.Column<int>(nullable: false),
                    StapleFoodId = table.Column<int>(nullable: false),
                    AddedByUserId = table.Column<int>(nullable: false),
                    AddedOn = table.Column<DateTime>(nullable: false),
                    LastUpdatedByOn = table.Column<DateTime>(nullable: true),
                    LastUpdatedByUserId = table.Column<int>(nullable: true),
                    Note = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupermarketStapleFood", x => new { x.SuperMarketId, x.StapleFoodId });
                    table.ForeignKey(
                        name: "FK_SupermarketStapleFood_StapleFood_StapleFoodId",
                        column: x => x.StapleFoodId,
                        principalTable: "StapleFood",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupermarketStapleFood_Supermarket_SuperMarketId",
                        column: x => x.SuperMarketId,
                        principalTable: "Supermarket",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupermarketVegetable",
                columns: table => new
                {
                    SupermarketId = table.Column<int>(nullable: false),
                    VegeId = table.Column<int>(nullable: false),
                    AddedByUserId = table.Column<int>(nullable: false),
                    AddedOn = table.Column<DateTime>(nullable: false),
                    LastUpdatedByOn = table.Column<DateTime>(nullable: true),
                    LastUpdatedByUserId = table.Column<int>(nullable: true),
                    Note = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupermarketVegetable", x => new { x.SupermarketId, x.VegeId });
                    table.ForeignKey(
                        name: "FK_SupermarketVegetable_Supermarket_SupermarketId",
                        column: x => x.SupermarketId,
                        principalTable: "Supermarket",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupermarketVegetable_Vegetable_VegeId",
                        column: x => x.VegeId,
                        principalTable: "Vegetable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EntreeMeat",
                columns: table => new
                {
                    EntreeId = table.Column<int>(nullable: false),
                    MeatId = table.Column<int>(nullable: false),
                    AddedByUserId = table.Column<int>(nullable: false),
                    AddedOn = table.Column<DateTime>(nullable: false),
                    LastUpdatedByOn = table.Column<DateTime>(nullable: true),
                    LastUpdatedByUserId = table.Column<int>(nullable: true),
                    Note = table.Column<string>(maxLength: 255, nullable: true),
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
                    AddedByUserId = table.Column<int>(nullable: false),
                    AddedOn = table.Column<DateTime>(nullable: false),
                    LastUpdatedByOn = table.Column<DateTime>(nullable: true),
                    LastUpdatedByUserId = table.Column<int>(nullable: true),
                    Note = table.Column<string>(maxLength: 255, nullable: true),
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
                name: "IX_Entree_StapleFoodId",
                table: "Entree",
                column: "StapleFoodId");

            migrationBuilder.CreateIndex(
                name: "IX_EntreeMeat_MeatId",
                table: "EntreeMeat",
                column: "MeatId");

            migrationBuilder.CreateIndex(
                name: "IX_EntreeVegetable_VegeId",
                table: "EntreeVegetable",
                column: "VegeId");

            migrationBuilder.CreateIndex(
                name: "IX_Supermarket_AddressRefId",
                table: "Supermarket",
                column: "AddressRefId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SupermarketMeat_MeatId",
                table: "SupermarketMeat",
                column: "MeatId");

            migrationBuilder.CreateIndex(
                name: "IX_SupermarketStapleFood_StapleFoodId",
                table: "SupermarketStapleFood",
                column: "StapleFoodId");

            migrationBuilder.CreateIndex(
                name: "IX_SupermarketVegetable_VegeId",
                table: "SupermarketVegetable",
                column: "VegeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntreeMeat");

            migrationBuilder.DropTable(
                name: "EntreeVegetable");

            migrationBuilder.DropTable(
                name: "MealTypes");

            migrationBuilder.DropTable(
                name: "SupermarketMeat");

            migrationBuilder.DropTable(
                name: "SupermarketStapleFood");

            migrationBuilder.DropTable(
                name: "SupermarketVegetable");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Entree");

            migrationBuilder.DropTable(
                name: "Meat");

            migrationBuilder.DropTable(
                name: "Supermarket");

            migrationBuilder.DropTable(
                name: "Vegetable");

            migrationBuilder.DropTable(
                name: "StapleFood");

            migrationBuilder.DropTable(
                name: "ContactAddress");
        }
    }
}
