﻿// <auto-generated />
using FamilyAssistant.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace FamilyAssistant.Migrations
{
    [DbContext(typeof(FaDbContext))]
    [Migration("20180114054218_ReSeedData")]
    partial class ReSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FamilyAssistant.Core.Models.Meal.Entree", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddedByUserId");

                    b.Property<DateTime>("AddedOn");

                    b.Property<int?>("CurrentRank");

                    b.Property<DateTime?>("LastUpdatedByOn");

                    b.Property<int?>("LastUpdatedByUserId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Note")
                        .HasMaxLength(255);

                    b.Property<int?>("StapleFoodId");

                    b.HasKey("Id");

                    b.HasIndex("StapleFoodId");

                    b.ToTable("Entree");
                });

            modelBuilder.Entity("FamilyAssistant.Core.Models.Meal.EntreeMeat", b =>
                {
                    b.Property<int>("EntreeId");

                    b.Property<int>("MeatId");

                    b.Property<int>("AddedByUserId");

                    b.Property<DateTime>("AddedOn");

                    b.Property<DateTime?>("LastUpdatedByOn");

                    b.Property<int?>("LastUpdatedByUserId");

                    b.Property<string>("Note")
                        .HasMaxLength(255);

                    b.Property<int>("Quantity");

                    b.HasKey("EntreeId", "MeatId");

                    b.HasIndex("MeatId");

                    b.ToTable("EntreeMeat");
                });

            modelBuilder.Entity("FamilyAssistant.Core.Models.Meal.EntreeVegetable", b =>
                {
                    b.Property<int>("EntreeId");

                    b.Property<int>("VegeId");

                    b.Property<int>("AddedByUserId");

                    b.Property<DateTime>("AddedOn");

                    b.Property<DateTime?>("LastUpdatedByOn");

                    b.Property<int?>("LastUpdatedByUserId");

                    b.Property<string>("Note")
                        .HasMaxLength(255);

                    b.Property<int>("Quantity");

                    b.HasKey("EntreeId", "VegeId");

                    b.HasIndex("VegeId");

                    b.ToTable("EntreeVegetable");
                });

            modelBuilder.Entity("FamilyAssistant.Core.Models.Meal.MealType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("MealTypes");
                });

            modelBuilder.Entity("FamilyAssistant.Core.Models.Meal.Meat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddedByUserId");

                    b.Property<DateTime>("AddedOn");

                    b.Property<DateTime?>("LastUpdatedByOn");

                    b.Property<int?>("LastUpdatedByUserId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Note")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Meat");
                });

            modelBuilder.Entity("FamilyAssistant.Core.Models.Meal.StapleFood", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddedByUserId");

                    b.Property<DateTime>("AddedOn");

                    b.Property<DateTime?>("LastUpdatedByOn");

                    b.Property<int?>("LastUpdatedByUserId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Note")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("StapleFood");
                });

            modelBuilder.Entity("FamilyAssistant.Core.Models.Meal.Supermarket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddedByUserId");

                    b.Property<DateTime>("AddedOn");

                    b.Property<int>("AddressRefId");

                    b.Property<DateTime?>("LastUpdatedByOn");

                    b.Property<int?>("LastUpdatedByUserId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Note")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("AddressRefId")
                        .IsUnique();

                    b.ToTable("Supermarket");
                });

            modelBuilder.Entity("FamilyAssistant.Core.Models.Meal.SupermarketMeat", b =>
                {
                    b.Property<int>("SupermarketId");

                    b.Property<int>("MeatId");

                    b.Property<int>("AddedByUserId");

                    b.Property<DateTime>("AddedOn");

                    b.Property<DateTime?>("LastUpdatedByOn");

                    b.Property<int?>("LastUpdatedByUserId");

                    b.Property<string>("Note")
                        .HasMaxLength(255);

                    b.HasKey("SupermarketId", "MeatId");

                    b.HasIndex("MeatId");

                    b.ToTable("SupermarketMeat");
                });

            modelBuilder.Entity("FamilyAssistant.Core.Models.Meal.SupermarketStapleFood", b =>
                {
                    b.Property<int>("SuperMarketId");

                    b.Property<int>("StapleFoodId");

                    b.Property<int>("AddedByUserId");

                    b.Property<DateTime>("AddedOn");

                    b.Property<DateTime?>("LastUpdatedByOn");

                    b.Property<int?>("LastUpdatedByUserId");

                    b.Property<string>("Note")
                        .HasMaxLength(255);

                    b.HasKey("SuperMarketId", "StapleFoodId");

                    b.HasIndex("StapleFoodId");

                    b.ToTable("SupermarketStapleFood");
                });

            modelBuilder.Entity("FamilyAssistant.Core.Models.Meal.SupermarketVegetable", b =>
                {
                    b.Property<int>("SupermarketId");

                    b.Property<int>("VegeId");

                    b.Property<int>("AddedByUserId");

                    b.Property<DateTime>("AddedOn");

                    b.Property<DateTime?>("LastUpdatedByOn");

                    b.Property<int?>("LastUpdatedByUserId");

                    b.Property<string>("Note")
                        .HasMaxLength(255);

                    b.HasKey("SupermarketId", "VegeId");

                    b.HasIndex("VegeId");

                    b.ToTable("SupermarketVegetable");
                });

            modelBuilder.Entity("FamilyAssistant.Core.Models.Meal.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddedByUserId");

                    b.Property<DateTime>("AddedOn");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("FirstName")
                        .HasMaxLength(30);

                    b.Property<bool?>("IsFAUser");

                    b.Property<DateTime>("LastLogIn");

                    b.Property<string>("LastName")
                        .HasMaxLength(30);

                    b.Property<DateTime?>("LastUpdatedByOn");

                    b.Property<int?>("LastUpdatedByUserId");

                    b.Property<string>("Note")
                        .HasMaxLength(255);

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FamilyAssistant.Core.Models.Meal.Vegetable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddedByUserId");

                    b.Property<DateTime>("AddedOn");

                    b.Property<DateTime?>("LastUpdatedByOn");

                    b.Property<int?>("LastUpdatedByUserId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Note")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Vegetable");
                });

            modelBuilder.Entity("FamilyAssistant.Core.Models.Shared.ContactAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddedByUserId");

                    b.Property<DateTime>("AddedOn");

                    b.Property<string>("Address1");

                    b.Property<string>("Address2");

                    b.Property<string>("City");

                    b.Property<DateTime?>("LastUpdatedByOn");

                    b.Property<int?>("LastUpdatedByUserId");

                    b.Property<string>("State");

                    b.Property<int>("ZipCode");

                    b.HasKey("Id");

                    b.ToTable("ContactAddress");
                });

            modelBuilder.Entity("FamilyAssistant.Core.Models.Meal.Entree", b =>
                {
                    b.HasOne("FamilyAssistant.Core.Models.Meal.StapleFood", "StapleFood")
                        .WithMany("EntreesWithCurrentStapleFood")
                        .HasForeignKey("StapleFoodId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("FamilyAssistant.Core.Models.Meal.EntreeMeat", b =>
                {
                    b.HasOne("FamilyAssistant.Core.Models.Meal.Entree", "Entree")
                        .WithMany("MeatsWithCurrentEntree")
                        .HasForeignKey("EntreeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FamilyAssistant.Core.Models.Meal.Meat", "Meat")
                        .WithMany("EntreesWithCurrentMeat")
                        .HasForeignKey("MeatId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FamilyAssistant.Core.Models.Meal.EntreeVegetable", b =>
                {
                    b.HasOne("FamilyAssistant.Core.Models.Meal.Entree", "Entree")
                        .WithMany("VegetablesWithCurrentEntree")
                        .HasForeignKey("EntreeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FamilyAssistant.Core.Models.Meal.Vegetable", "Vege")
                        .WithMany("EntreesWithCurrentVegetable")
                        .HasForeignKey("VegeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FamilyAssistant.Core.Models.Meal.Supermarket", b =>
                {
                    b.HasOne("FamilyAssistant.Core.Models.Shared.ContactAddress", "AddressInfo")
                        .WithOne("Supermarket")
                        .HasForeignKey("FamilyAssistant.Core.Models.Meal.Supermarket", "AddressRefId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FamilyAssistant.Core.Models.Meal.SupermarketMeat", b =>
                {
                    b.HasOne("FamilyAssistant.Core.Models.Meal.Meat", "Meat")
                        .WithMany()
                        .HasForeignKey("MeatId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FamilyAssistant.Core.Models.Meal.Supermarket", "Supermarket")
                        .WithMany()
                        .HasForeignKey("SupermarketId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FamilyAssistant.Core.Models.Meal.SupermarketStapleFood", b =>
                {
                    b.HasOne("FamilyAssistant.Core.Models.Meal.StapleFood", "StapleFood")
                        .WithMany()
                        .HasForeignKey("StapleFoodId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FamilyAssistant.Core.Models.Meal.Supermarket", "Supermarket")
                        .WithMany()
                        .HasForeignKey("SuperMarketId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FamilyAssistant.Core.Models.Meal.SupermarketVegetable", b =>
                {
                    b.HasOne("FamilyAssistant.Core.Models.Meal.Supermarket", "Supermarket")
                        .WithMany()
                        .HasForeignKey("SupermarketId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FamilyAssistant.Core.Models.Meal.Vegetable", "Vege")
                        .WithMany()
                        .HasForeignKey("VegeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}