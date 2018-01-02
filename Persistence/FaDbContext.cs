using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FamilyAssistant.Core.Models.Meal;
using Microsoft.EntityFrameworkCore;

namespace FamilyAssistant.Persistence {
        public class FaDbContext : DbContext {
                public FaDbContext (DbContextOptions<FaDbContext> options) : base (options) {

                }

                public DbSet<Entree> Entrees { get; set; }
                public DbSet<Vegetable> Vegetables { get; set; }
                public DbSet<Meat> Meats { get; set; }
                public DbSet<User> Users { get; set; }

                protected override void OnModelCreating (ModelBuilder modelBuilder) {
                        //One to One
                        //modelBuilder.Entity<Entree>()
                        //  .HasOne(e => e.BaseOption)
                        //  .WithOne(bo => bo.Entree)
                        //  .HasForeignKey<Entree>(e => e.BaseOptionId);
                        //One to Many
                    /*  We don't need clarify here again since Model Class contains FK and Object
                        modelBuilder.Entity<User> ()
                                .HasMany (u => u.AddedVegetables)
                                .WithOne (v => v.AddedBy);
                        modelBuilder.Entity<User> ()
                                .HasMany (u => u.AddedMeats)
                                .WithOne (m => m.AddedBy);
                        modelBuilder.Entity<User> ()
                                .HasMany (u => u.AddedEntrees)
                                .WithOne (e => e.AddedBy);
                        modelBuilder.Entity<User> ()
                                .HasMany (u => u.AddedBaseOptions)
                                .WithOne (bo => bo.AddedBy);
                        modelBuilder.Entity<User> ()
                                .HasMany (u => u.AddedEntreeVegetables)
                                .WithOne (ev => ev.AddedBy);
                        modelBuilder.Entity<User> ()
                                .HasMany (u => u.AddedEntreeMeats)
                                .WithOne (em => em.AddedBy); */

                        //Many to Many
                        modelBuilder.Entity<EntreeMeat> ().HasKey (em =>
                                new { em.EntreeId, em.MeatId });
                        modelBuilder.Entity<EntreeVegetable> ().HasKey (ev =>
                                new { ev.EntreeId, ev.VegeId });
                }
        }
}