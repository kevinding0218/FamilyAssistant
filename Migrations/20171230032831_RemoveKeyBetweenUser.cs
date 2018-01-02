using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FamilyAssistant.Migrations
{
    public partial class RemoveKeyBetweenUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "FK_Vegetable_Users_UserID",
                table: "Vegetable");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Vegetable_UserID",
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
                name: "UserID",
                table: "Vegetable");

            migrationBuilder.RenameColumn(
                name: "AddedByUserID",
                table: "Meat",
                newName: "AddedByUserId");

            migrationBuilder.RenameColumn(
                name: "AddedByUserID",
                table: "EntreeVegetable",
                newName: "AddedByUserId");

            migrationBuilder.RenameColumn(
                name: "AddedByUserID",
                table: "EntreeMeat",
                newName: "AddedByUserId");

            migrationBuilder.RenameColumn(
                name: "AddedByUserID",
                table: "Entree",
                newName: "AddedByUserId");

            migrationBuilder.RenameColumn(
                name: "AddedByUserID",
                table: "BaseOption",
                newName: "AddedByUserId");

            migrationBuilder.AlterColumn<int>(
                name: "AddedByUserId",
                table: "Meat",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AddedByUserId",
                table: "EntreeVegetable",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AddedByUserId",
                table: "EntreeMeat",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AddedByUserId",
                table: "Entree",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AddedByUserId",
                table: "BaseOption",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AddedByUserId",
                table: "Meat",
                newName: "AddedByUserID");

            migrationBuilder.RenameColumn(
                name: "AddedByUserId",
                table: "EntreeVegetable",
                newName: "AddedByUserID");

            migrationBuilder.RenameColumn(
                name: "AddedByUserId",
                table: "EntreeMeat",
                newName: "AddedByUserID");

            migrationBuilder.RenameColumn(
                name: "AddedByUserId",
                table: "Entree",
                newName: "AddedByUserID");

            migrationBuilder.RenameColumn(
                name: "AddedByUserId",
                table: "BaseOption",
                newName: "AddedByUserID");

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Vegetable",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AddedByUserID",
                table: "Meat",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AddedByUserID",
                table: "EntreeVegetable",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AddedByUserID",
                table: "EntreeMeat",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AddedByUserID",
                table: "Entree",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AddedByUserID",
                table: "BaseOption",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(maxLength: 100, nullable: false),
                    FirstName = table.Column<string>(maxLength: 30, nullable: true),
                    IsFAUser = table.Column<bool>(nullable: true),
                    LastLogIn = table.Column<DateTime>(nullable: false),
                    LastName = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vegetable_UserID",
                table: "Vegetable",
                column: "UserID");

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
                name: "FK_Vegetable_Users_UserID",
                table: "Vegetable",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
