using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FamilyAssistant.Migrations
{
    public partial class SeedOtherTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Meat SET AddedByUserID = (SELECT UserID FROM Users WHERE Email = 'kevinding0218@gmail.com')");
            migrationBuilder.Sql("UPDATE BaseOption SET AddedByUserID = (SELECT UserID FROM Users WHERE Email = 'kevinding0218@gmail.com')");
            migrationBuilder.Sql("UPDATE Entree SET AddedByUserID = (SELECT UserID FROM Users WHERE Email = 'kevinding0218@gmail.com')");
            migrationBuilder.Sql("UPDATE EntreeMeat SET AddedByUserID = (SELECT UserID FROM Users WHERE Email = 'kevinding0218@gmail.com')");
            migrationBuilder.Sql("UPDATE EntreeVegetable SET AddedByUserID = (SELECT UserID FROM Users WHERE Email = 'kevinding0218@gmail.com')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Meat SET AddedByUserID = null");
            migrationBuilder.Sql("UPDATE BaseOption SET AddedByUserID = null");
            migrationBuilder.Sql("UPDATE Entree SET AddedByUserID = null");
            migrationBuilder.Sql("UPDATE EntreeMeat SET AddedByUserID = null");
            migrationBuilder.Sql("UPDATE EntreeVegetable SET AddedByUserID = null");
        }
    }
}
