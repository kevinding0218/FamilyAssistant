using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FamilyAssistant.Migrations
{
    public partial class addUsersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddedBy",
                table: "Vegetable");

            migrationBuilder.DropColumn(
                name: "AddedBy",
                table: "Meat");

            migrationBuilder.DropColumn(
                name: "AddedBy",
                table: "EntreeVegetable");

            migrationBuilder.DropColumn(
                name: "AddedBy",
                table: "EntreeMeat");

            migrationBuilder.DropColumn(
                name: "AddedBy",
                table: "Entree");

            migrationBuilder.DropColumn(
                name: "AddedBy",
                table: "BaseOption");

            migrationBuilder.AddColumn<int>(
                name: "AddedByUID",
                table: "Vegetable",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AddedByUID",
                table: "Meat",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AddedByUserID",
                table: "Meat",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AddedByUID",
                table: "EntreeVegetable",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AddedByUserID",
                table: "EntreeVegetable",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AddedByUID",
                table: "EntreeMeat",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AddedByUserID",
                table: "EntreeMeat",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AddedByUID",
                table: "Entree",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AddedByUserID",
                table: "Entree",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AddedByUID",
                table: "BaseOption",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AddedByUserID",
                table: "BaseOption",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddedByUID = table.Column<int>(nullable: true),
                    AddedByUserID = table.Column<int>(nullable: true),
                    AddedOn = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: false),
                    FirstName = table.Column<string>(maxLength: 30, nullable: true),
                    IsFAUser = table.Column<bool>(nullable: true),
                    LastLogIn = table.Column<DateTime>(nullable: false),
                    LastName = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_Users_Users_AddedByUserID",
                        column: x => x.AddedByUserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vegetable_AddedByUID",
                table: "Vegetable",
                column: "AddedByUID");

            migrationBuilder.CreateIndex(
                name: "IX_Meat_AddedByUserID",
                table: "Meat",
                column: "AddedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_EntreeVegetable_AddedByUserID",
                table: "EntreeVegetable",
                column: "AddedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_EntreeMeat_AddedByUserID",
                table: "EntreeMeat",
                column: "AddedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Entree_AddedByUserID",
                table: "Entree",
                column: "AddedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_BaseOption_AddedByUserID",
                table: "BaseOption",
                column: "AddedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_AddedByUserID",
                table: "Users",
                column: "AddedByUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseOption_Users_AddedByUserID",
                table: "BaseOption",
                column: "AddedByUserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Entree_Users_AddedByUserID",
                table: "Entree",
                column: "AddedByUserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EntreeMeat_Users_AddedByUserID",
                table: "EntreeMeat",
                column: "AddedByUserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EntreeVegetable_Users_AddedByUserID",
                table: "EntreeVegetable",
                column: "AddedByUserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Meat_Users_AddedByUserID",
                table: "Meat",
                column: "AddedByUserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vegetable_Users_AddedByUID",
                table: "Vegetable",
                column: "AddedByUID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaseOption_Users_AddedByUserID",
                table: "BaseOption");

            migrationBuilder.DropForeignKey(
                name: "FK_Entree_Users_AddedByUserID",
                table: "Entree");

            migrationBuilder.DropForeignKey(
                name: "FK_EntreeMeat_Users_AddedByUserID",
                table: "EntreeMeat");

            migrationBuilder.DropForeignKey(
                name: "FK_EntreeVegetable_Users_AddedByUserID",
                table: "EntreeVegetable");

            migrationBuilder.DropForeignKey(
                name: "FK_Meat_Users_AddedByUserID",
                table: "Meat");

            migrationBuilder.DropForeignKey(
                name: "FK_Vegetable_Users_AddedByUID",
                table: "Vegetable");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Vegetable_AddedByUID",
                table: "Vegetable");

            migrationBuilder.DropIndex(
                name: "IX_Meat_AddedByUserID",
                table: "Meat");

            migrationBuilder.DropIndex(
                name: "IX_EntreeVegetable_AddedByUserID",
                table: "EntreeVegetable");

            migrationBuilder.DropIndex(
                name: "IX_EntreeMeat_AddedByUserID",
                table: "EntreeMeat");

            migrationBuilder.DropIndex(
                name: "IX_Entree_AddedByUserID",
                table: "Entree");

            migrationBuilder.DropIndex(
                name: "IX_BaseOption_AddedByUserID",
                table: "BaseOption");

            migrationBuilder.DropColumn(
                name: "AddedByUID",
                table: "Vegetable");

            migrationBuilder.DropColumn(
                name: "AddedByUID",
                table: "Meat");

            migrationBuilder.DropColumn(
                name: "AddedByUserID",
                table: "Meat");

            migrationBuilder.DropColumn(
                name: "AddedByUID",
                table: "EntreeVegetable");

            migrationBuilder.DropColumn(
                name: "AddedByUserID",
                table: "EntreeVegetable");

            migrationBuilder.DropColumn(
                name: "AddedByUID",
                table: "EntreeMeat");

            migrationBuilder.DropColumn(
                name: "AddedByUserID",
                table: "EntreeMeat");

            migrationBuilder.DropColumn(
                name: "AddedByUID",
                table: "Entree");

            migrationBuilder.DropColumn(
                name: "AddedByUserID",
                table: "Entree");

            migrationBuilder.DropColumn(
                name: "AddedByUID",
                table: "BaseOption");

            migrationBuilder.DropColumn(
                name: "AddedByUserID",
                table: "BaseOption");

            migrationBuilder.AddColumn<int>(
                name: "AddedBy",
                table: "Vegetable",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AddedBy",
                table: "Meat",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AddedBy",
                table: "EntreeVegetable",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AddedBy",
                table: "EntreeMeat",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AddedBy",
                table: "Entree",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AddedBy",
                table: "BaseOption",
                nullable: false,
                defaultValue: 0);
        }
    }
}
