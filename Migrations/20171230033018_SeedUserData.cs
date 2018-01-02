using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FamilyAssistant.Migrations
{
    public partial class SeedUserData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Users(Email, FirstName, LastName, IsFAUser, LastLogIn) VALUES ('kevinding0218@gmail.com', 'Ran', 'Ding', 1, GETDATE())");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Users WHERE Email = 'kevinding0218@gmail.com'");
        }
    }
}
