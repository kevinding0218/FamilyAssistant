using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FamilyAssistant.Migrations
{
    public partial class SeedUserDataUpdateAddedByUserID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //Seed User Table
            migrationBuilder.Sql("INSERT INTO Users(Email, FirstName, LastName, IsFAUser, LastLogIn) VALUES ('kevinding0218@gmail.com', 'Ran', 'Ding', 1, GETDATE())");
            migrationBuilder.Sql("UPDATE Vegetable SET AddedByUserID = (SELECT UserID FROM Users WHERE Email = 'kevinding0218@gmail.com')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Users WHERE Email = 'kevinding0218@gmail.com'");
            migrationBuilder.Sql("UPDATE Vegetable SET AddedByUserID = null");
        }
    }
}
