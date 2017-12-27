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
    [Migration("20171227052416_AddInsertLogToBaseOption")]
    partial class AddInsertLogToBaseOption
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FamilyAssistant.Core.Models.BaseOption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddedBy");

                    b.Property<DateTime>("AddedOn");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("BaseOption");
                });

            modelBuilder.Entity("FamilyAssistant.Core.Models.Entree", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddedBy");

                    b.Property<DateTime>("AddedOn");

                    b.Property<int?>("BaseOptionId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("BaseOptionId");

                    b.ToTable("Entree");
                });

            modelBuilder.Entity("FamilyAssistant.Core.Models.EntreeMeat", b =>
                {
                    b.Property<int>("EntreeId");

                    b.Property<int>("MeatId");

                    b.Property<int>("AddedBy");

                    b.Property<DateTime>("AddedOn");

                    b.Property<int>("Quantity");

                    b.HasKey("EntreeId", "MeatId");

                    b.HasIndex("MeatId");

                    b.ToTable("EntreeMeat");
                });

            modelBuilder.Entity("FamilyAssistant.Core.Models.EntreeVege", b =>
                {
                    b.Property<int>("EntreeId");

                    b.Property<int>("VegeId");

                    b.Property<int>("AddedBy");

                    b.Property<DateTime>("AddedOn");

                    b.Property<int>("Quantity");

                    b.HasKey("EntreeId", "VegeId");

                    b.HasIndex("VegeId");

                    b.ToTable("EntreeVegetable");
                });

            modelBuilder.Entity("FamilyAssistant.Core.Models.Meat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddedBy");

                    b.Property<DateTime>("AddedOn");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Meat");
                });

            modelBuilder.Entity("FamilyAssistant.Core.Models.Vegetable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddedBy");

                    b.Property<DateTime>("AddedOn");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Vegetable");
                });

            modelBuilder.Entity("FamilyAssistant.Core.Models.Entree", b =>
                {
                    b.HasOne("FamilyAssistant.Core.Models.BaseOption", "BaseOption")
                        .WithMany("Entrees")
                        .HasForeignKey("BaseOptionId");
                });

            modelBuilder.Entity("FamilyAssistant.Core.Models.EntreeMeat", b =>
                {
                    b.HasOne("FamilyAssistant.Core.Models.Entree", "Entree")
                        .WithMany("Meats")
                        .HasForeignKey("EntreeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FamilyAssistant.Core.Models.Meat", "Meat")
                        .WithMany()
                        .HasForeignKey("MeatId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FamilyAssistant.Core.Models.EntreeVege", b =>
                {
                    b.HasOne("FamilyAssistant.Core.Models.Entree", "Entree")
                        .WithMany("Vegetables")
                        .HasForeignKey("EntreeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FamilyAssistant.Core.Models.Vegetable", "Vege")
                        .WithMany()
                        .HasForeignKey("VegeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
