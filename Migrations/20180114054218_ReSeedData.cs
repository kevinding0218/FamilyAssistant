using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FamilyAssistant.Migrations
{
    public partial class ReSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Users(Email, FirstName, LastName, IsFAUser, LastLogIn, AddedByUserId, AddedOn) VALUES ('kevinding0218@gmail.com', 'Ran', 'Ding', 1, GETDATE(), 1, GETDATE())");

            //Seed into Vegetable
            migrationBuilder.Sql("INSERT INTO Vegetable(Name, AddedByUserId, AddedOn) VALUES ('小青菜', (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Vegetable(Name, AddedByUserId, AddedOn) VALUES ('大青菜', (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Vegetable(Name, AddedByUserId, AddedOn) VALUES ('小白菜', (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Vegetable(Name, AddedByUserId, AddedOn) VALUES ('大白菜', (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Vegetable(Name, AddedByUserId, AddedOn) VALUES ('芹菜', (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Vegetable(Name, AddedByUserId, AddedOn) VALUES ('中式有机花菜', (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Vegetable(Name, AddedByUserId, AddedOn) VALUES ('西红柿', (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Vegetable(Name, AddedByUserId, AddedOn) VALUES ('茄子', (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Vegetable(Name, AddedByUserId, AddedOn) VALUES ('青椒', (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Vegetable(Name, AddedByUserId, AddedOn) VALUES ('黄洋葱', (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Vegetable(Name, AddedByUserId, AddedOn) VALUES ('嫩豆腐', (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Vegetable(Name, AddedByUserId, AddedOn) VALUES ('滑豆腐', (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Vegetable(Name, AddedByUserId, AddedOn) VALUES ('老豆腐', (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Vegetable(Name, AddedByUserId, AddedOn) VALUES ('西兰花', (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");

            //Seed into Meat
            migrationBuilder.Sql("INSERT INTO Meat(Name, AddedByUserId, AddedOn) VALUES ('牛腱', (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Meat(Name, AddedByUserId, AddedOn) VALUES ('牛里脊', (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Meat(Name, AddedByUserId, AddedOn) VALUES ('牛尾骨', (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Meat(Name, AddedByUserId, AddedOn) VALUES ('肥牛片', (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Meat(Name, AddedByUserId, AddedOn) VALUES ('日式高级和牛片', (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Meat(Name, AddedByUserId, AddedOn) VALUES ('日式中级和牛片', (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Meat(Name, AddedByUserId, AddedOn) VALUES ('火锅牛里脊片', (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Meat(Name, AddedByUserId, AddedOn) VALUES ('鸡蛋', (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Meat(Name, AddedByUserId, AddedOn) VALUES ('台湾香肠', (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");

            //Seed into StapleFood
            migrationBuilder.Sql("INSERT INTO StapleFood(Name, AddedByUserId, AddedOn) VALUES ('米饭', (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO StapleFood(Name, AddedByUserId, AddedOn) VALUES ('面条', (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO StapleFood(Name, AddedByUserId, AddedOn) VALUES ('大馒头', (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO StapleFood(Name, AddedByUserId, AddedOn) VALUES ('巧克力馒头', (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO StapleFood(Name, AddedByUserId, AddedOn) VALUES ('袖珍馒头', (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO StapleFood(Name, AddedByUserId, AddedOn) VALUES ('年糕片', (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO StapleFood(Name, AddedByUserId, AddedOn) VALUES ('年糕条', (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");

            //Seed into Entree
            migrationBuilder.Sql("INSERT INTO Entree(Name, StapleFoodId, AddedByUserId, AddedOn, CurrentRank) VALUES ('锅塌豆腐', (SELECT ID FROM StapleFood WHERE NAME = '米饭'), (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE(), 10)");
            migrationBuilder.Sql("INSERT INTO Entree(Name, StapleFoodId, AddedByUserId, AddedOn, CurrentRank) VALUES ('西红柿炒花菜', (SELECT ID FROM StapleFood WHERE NAME = '米饭'), (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE(), 9)");
            migrationBuilder.Sql("INSERT INTO Entree(Name, StapleFoodId, AddedByUserId, AddedOn, CurrentRank) VALUES ('西红柿炒鸡蛋', (SELECT ID FROM StapleFood WHERE NAME = '米饭'), (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE(), 8)");
            migrationBuilder.Sql("INSERT INTO Entree(Name, StapleFoodId, AddedByUserId, AddedOn, CurrentRank) VALUES ('炸馒头', (SELECT ID FROM StapleFood WHERE NAME = '大馒头'), (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE(), 6)");
            migrationBuilder.Sql("INSERT INTO Entree(Name, StapleFoodId, AddedByUserId, AddedOn, CurrentRank) VALUES ('西红柿鸡蛋打卤面', (SELECT ID FROM StapleFood WHERE NAME = '面条'), (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE(), 9)");
            migrationBuilder.Sql("INSERT INTO Entree(Name, StapleFoodId, AddedByUserId, AddedOn, CurrentRank) VALUES ('年糕汤', (SELECT ID FROM StapleFood WHERE NAME = '年糕片'), (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE(), 10)");
            migrationBuilder.Sql("INSERT INTO Entree(Name, StapleFoodId, AddedByUserId, AddedOn, CurrentRank) VALUES ('黑椒牛柳面', (SELECT ID FROM StapleFood WHERE NAME = '面条'), (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE(), 8)");
            migrationBuilder.Sql("INSERT INTO Entree(Name, StapleFoodId, AddedByUserId, AddedOn, CurrentRank) VALUES ('黑椒炒牛柳', (SELECT ID FROM StapleFood WHERE NAME = '米饭'), (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE(), 8)");
            migrationBuilder.Sql("INSERT INTO Entree(Name, StapleFoodId, AddedByUserId, AddedOn, CurrentRank) VALUES ('西红柿牛肉汤面', (SELECT ID FROM StapleFood WHERE NAME = '面条'), (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE(), 10)");
            migrationBuilder.Sql("INSERT INTO Entree(Name, StapleFoodId, AddedByUserId, AddedOn, CurrentRank) VALUES ('XO酱蛋炒饭', (SELECT ID FROM StapleFood   WHERE NAME = '米饭'), (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE(), 10)");

            //Seed into EntreeMeat
            migrationBuilder.Sql("INSERT INTO EntreeMeat(EntreeId, MeatId, Quantity, AddedByUserId, AddedOn) VALUES (" +
              "(SELECT ID FROM Entree WHERE NAME = '西红柿炒鸡蛋'), " +
              "(SELECT ID FROM MEAT WHERE NAME = '鸡蛋'), 1, (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
              migrationBuilder.Sql("INSERT INTO EntreeMeat(EntreeId, MeatId, Quantity, AddedByUserId, AddedOn) VALUES (" +
              "(SELECT ID FROM Entree WHERE NAME = '西红柿鸡蛋打卤面'), " +
              "(SELECT ID FROM MEAT WHERE NAME = '鸡蛋'), 1, (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO EntreeMeat(EntreeId, MeatId, Quantity, AddedByUserId, AddedOn) VALUES (" +
              "(SELECT ID FROM Entree WHERE NAME = '黑椒牛柳面'), " +
              "(SELECT ID FROM MEAT WHERE NAME = '牛里脊'), 1, (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO EntreeMeat(EntreeId, MeatId, Quantity, AddedByUserId, AddedOn) VALUES (" +
              "(SELECT ID FROM Entree WHERE NAME = '黑椒炒牛柳'), " +
              "(SELECT ID FROM MEAT WHERE NAME = '牛里脊'), 1, (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO EntreeMeat(EntreeId, MeatId, Quantity, AddedByUserId, AddedOn) VALUES (" +
              "(SELECT ID FROM Entree WHERE NAME = '西红柿牛肉汤面'), " +
              "(SELECT ID FROM MEAT WHERE NAME = '牛腱'), 1, (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO EntreeMeat(EntreeId, MeatId, Quantity, AddedByUserId, AddedOn) VALUES (" +
              "(SELECT ID FROM Entree WHERE NAME = 'XO酱蛋炒饭'), " +
              "(SELECT ID FROM MEAT WHERE NAME = '鸡蛋'), 1, (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO EntreeMeat(EntreeId, MeatId, Quantity, AddedByUserId, AddedOn) VALUES (" +
              "(SELECT ID FROM Entree WHERE NAME = 'XO酱蛋炒饭'), " +
              "(SELECT ID FROM MEAT WHERE NAME = '台湾香肠'), 1, (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");

            //Seed into EntreeVege
            migrationBuilder.Sql("INSERT INTO EntreeVegetable(EntreeId, VegeId, Quantity, AddedByUserId, AddedOn) VALUES (" +
              "(SELECT ID FROM Entree WHERE NAME = '锅塌豆腐'), " +
              "(SELECT ID FROM Vegetable WHERE NAME = '滑豆腐'), " +
              "1, (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO EntreeVegetable(EntreeId, VegeId, Quantity, AddedByUserId, AddedOn) VALUES (" +
              "(SELECT ID FROM Entree WHERE NAME = '西红柿炒花菜'), " +
              "(SELECT ID FROM Vegetable WHERE NAME = '西红柿'), " +
              "1, (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO EntreeVegetable(EntreeId, VegeId, Quantity, AddedByUserId, AddedOn) VALUES (" +
              "(SELECT ID FROM Entree WHERE NAME = '西红柿炒花菜'), " +
              "(SELECT ID FROM Vegetable WHERE NAME = '中式有机花菜'), " +
              "1, (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO EntreeVegetable(EntreeId, VegeId, Quantity, AddedByUserId, AddedOn) VALUES (" +
              "(SELECT ID FROM Entree WHERE NAME = '西红柿炒鸡蛋'), " +
              "(SELECT ID FROM Vegetable WHERE NAME = '西红柿'), " +
              "1, (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO EntreeVegetable(EntreeId, VegeId, Quantity, AddedByUserId, AddedOn) VALUES (" +
              "(SELECT ID FROM Entree WHERE NAME = '西红柿鸡蛋打卤面'), " +
              "(SELECT ID FROM Vegetable WHERE NAME = '西红柿'), " +
              "1, (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO EntreeVegetable(EntreeId, VegeId, Quantity, AddedByUserId, AddedOn) VALUES (" +
              "(SELECT ID FROM Entree WHERE NAME = '年糕汤'), " +
              "(SELECT ID FROM Vegetable WHERE NAME = '小白菜')," +
              " 1, (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO EntreeVegetable(EntreeId, VegeId, Quantity, AddedByUserId, AddedOn) VALUES (" +
              "(SELECT ID FROM Entree WHERE NAME = '黑椒牛柳面'), " +
              "(SELECT ID FROM Vegetable WHERE NAME = '青椒')," +
              " 1, (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO EntreeVegetable(EntreeId, VegeId, Quantity, AddedByUserId, AddedOn) VALUES (" +
              "(SELECT ID FROM Entree WHERE NAME = '黑椒牛柳面'), " +
              "(SELECT ID FROM Vegetable WHERE NAME = '黄洋葱')," +
              " 1, (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO EntreeVegetable(EntreeId, VegeId, Quantity, AddedByUserId, AddedOn) VALUES (" +
              "(SELECT ID FROM Entree WHERE NAME = '黑椒炒牛柳'), " +
              "(SELECT ID FROM Vegetable WHERE NAME = '青椒')," +
              " 1, (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO EntreeVegetable(EntreeId, VegeId, Quantity, AddedByUserId, AddedOn) VALUES (" +
              "(SELECT ID FROM Entree WHERE NAME = '黑椒炒牛柳'), " +
              "(SELECT ID FROM Vegetable WHERE NAME = '黄洋葱')," +
              " 1, (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO EntreeVegetable(EntreeId, VegeId, Quantity, AddedByUserId, AddedOn) VALUES (" +
              "(SELECT ID FROM Entree WHERE NAME = '西红柿牛肉汤面'), " +
              "(SELECT ID FROM Vegetable WHERE NAME = '西红柿')," +
              " 1, (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
            migrationBuilder.Sql("INSERT INTO EntreeVegetable(EntreeId, VegeId, Quantity, AddedByUserId, AddedOn) VALUES (" +
              "(SELECT ID FROM Entree WHERE NAME = '西红柿牛肉汤面'), " +
              "(SELECT ID FROM Vegetable WHERE NAME = '大青菜')," +
              " 1, (SELECT USERID FROM Users WHERE Email = 'kevinding0218@gmail.com'), GETDATE())");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Users WHERE Email = 'kevinding0218@gmail.com'");

            migrationBuilder.Sql("DELETE FROM EntreeMeat");
            migrationBuilder.Sql("DELETE FROM EntreeVegetable");
            migrationBuilder.Sql("DELETE FROM Vegetable");
            migrationBuilder.Sql("DELETE FROM Meat");
            migrationBuilder.Sql("DELETE FROM StapleFood");
            migrationBuilder.Sql("DELETE FROM Entree");
        }
    }
}
