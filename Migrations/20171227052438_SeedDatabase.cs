using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FamilyAssistant.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //Seed into Vegetable
            migrationBuilder.Sql("INSERT INTO Vegetable(Name, AddedBy, AddedOn) VALUES ('Shanghai Bok Choy', 1000, GETDATE())");
            migrationBuilder.Sql("INSERT INTO Vegetable(Name, AddedBy, AddedOn) VALUES ('Cabbage', 1000, GETDATE())");
            migrationBuilder.Sql("INSERT INTO Vegetable(Name, AddedBy, AddedOn) VALUES ('Celery', 1000, GETDATE())");
            migrationBuilder.Sql("INSERT INTO Vegetable(Name, AddedBy, AddedOn) VALUES ('Tofu', 1000, GETDATE())");

            //Seed into Meat
            migrationBuilder.Sql("INSERT INTO Meat(Name, AddedBy, AddedOn) VALUES ('Beef', 1000, GETDATE())");
            migrationBuilder.Sql("INSERT INTO Meat(Name, AddedBy, AddedOn) VALUES ('Pork', 1000, GETDATE())");

            //Seed into BaseOption
            migrationBuilder.Sql("INSERT INTO BaseOption(Name, AddedBy, AddedOn) VALUES ('Rice', 1000, GETDATE())");
            migrationBuilder.Sql("INSERT INTO BaseOption(Name, AddedBy, AddedOn) VALUES ('Noodle', 1000, GETDATE())");

            //Seed into Entree
            migrationBuilder.Sql("INSERT INTO Entree(Name, BaseOptionId, AddedBy, AddedOn) VALUES ('Celery With Tofu', null, 1000, GETDATE())");
            migrationBuilder.Sql("INSERT INTO Entree(Name, BaseOptionId, AddedBy, AddedOn) VALUES ('Basic Bok Choy', null, 1000, GETDATE())");
            migrationBuilder.Sql("INSERT INTO Entree(Name, BaseOptionId, AddedBy, AddedOn) VALUES ('Tofu Noodle', (SELECT ID FROM BaseOption WHERE NAME = 'Noodle'), 1000, GETDATE())");
            migrationBuilder.Sql("INSERT INTO Entree(Name, BaseOptionId, AddedBy, AddedOn) VALUES ('Beef with Cabbage', null, 1000, GETDATE())");

            //Seed into EntreeMeat
            migrationBuilder.Sql("INSERT INTO EntreeMeat(EntreeId, MeatId, Quantity, AddedBy, AddedOn) VALUES (" +
              "(SELECT ID FROM Entree WHERE NAME = 'Beef with Cabbage'), " +
              "(SELECT ID FROM MEAT WHERE NAME = 'Beef'), 1, 1000, GETDATE())");

            //Seed into EntreeVege
            migrationBuilder.Sql("INSERT INTO EntreeVegetable(EntreeId, VegeId, Quantity, AddedBy, AddedOn) VALUES (" +
              "(SELECT ID FROM Entree WHERE NAME = 'Celery With Tofu'), " +
              "(SELECT ID FROM Vegetable WHERE NAME = 'Celery'), 1, " +
              "1000, GETDATE())");
            migrationBuilder.Sql("INSERT INTO EntreeVegetable(EntreeId, VegeId, Quantity, AddedBy, AddedOn) VALUES (" +
              "(SELECT ID FROM Entree WHERE NAME = 'Celery With Tofu'), " +
              "(SELECT ID FROM Vegetable WHERE NAME = 'Tofu'), 1, " +
              "1000, GETDATE())");
            migrationBuilder.Sql("INSERT INTO EntreeVegetable(EntreeId, VegeId, Quantity, AddedBy, AddedOn) VALUES (" +
              "(SELECT ID FROM Entree WHERE NAME = 'Basic Bok Choy'), " +
              "(SELECT ID FROM Vegetable WHERE NAME = 'Shanghai Bok Choy'), " +
              "1, 1000, GETDATE())");
            migrationBuilder.Sql("INSERT INTO EntreeVegetable(EntreeId, VegeId, Quantity, AddedBy, AddedOn) VALUES (" +
              "(SELECT ID FROM Entree WHERE NAME = 'Tofu Noodle'), " +
              "(SELECT ID FROM Vegetable WHERE NAME = 'Tofu'), " +
              "1, 1000, GETDATE())");
            migrationBuilder.Sql("INSERT INTO EntreeVegetable(EntreeId, VegeId, Quantity, AddedBy, AddedOn) VALUES (" +
              "(SELECT ID FROM Entree WHERE NAME = 'Beef with Cabbage'), " +
              "(SELECT ID FROM Vegetable WHERE NAME = 'Cabbage')," +
              " 1, 1000, GETDATE())");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM EntreeMeat");
            migrationBuilder.Sql("DELETE FROM EntreeVegetable");
            migrationBuilder.Sql("DELETE FROM Vegetable");
            migrationBuilder.Sql("DELETE FROM Meat");
            migrationBuilder.Sql("DELETE FROM BaseOption");
            migrationBuilder.Sql("DELETE FROM Entree");
        }
    }
}
