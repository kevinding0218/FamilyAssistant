using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FamilyAssistant.Core.Models.Meal;
using FamilyAssistant.Core.Models.Shared;
using Microsoft.EntityFrameworkCore;

namespace FamilyAssistant.Persistence {
        public class FaDbContext : DbContext {
                public FaDbContext (DbContextOptions<FaDbContext> options) : base (options) {

                }

                public DbSet<MealType> MealTypes { get; set; }
                public DbSet<Entree> Entrees { get; set; }
                public DbSet<Vegetable> Vegetables { get; set; }
                public DbSet<Meat> Meats { get; set; }
                public DbSet<User> Users { get; set; }
                public DbSet<Supermarket> SuperMarkets { get; set; }
                public DbSet<Ingredient> Ingredients { get; set; }

                protected override void OnModelCreating (ModelBuilder modelBuilder) {
                        //One to One
                        modelBuilder.Entity<ContactAddress>()
                                .HasOne(ca => ca.Supermarket)
                                .WithOne(sm => sm.AddressInfo)
                                .HasForeignKey<Supermarket>(sm => sm.AddressRefId);
                        //One to Many
                        // configured by starting with "many" to "one" relationship:
                        /*     
                        modelBuilder.Entity<MealType>()
                                .HasMany(mt => mt.Entrees)
                                .WithOne(e => e.MealType);
                        modelBuilder.Entity<MealType>()
                                .HasMany(mt => mt.Vegetables)
                                .WithOne(v => v.MealType);
                        modelBuilder.Entity<MealType>()
                                .HasMany(mt => mt.Meats)
                                .WithOne(m => m.MealType);
                        modelBuilder.Entity<MealType>()
                                .HasMany(mt => mt.StapleFoods)
                                .WithOne(sf => sf.MealType); 
                        */
                        // configured by starting with the "one" to "many" relationship
                        modelBuilder.Entity<Entree>()
                                .HasOne(e => e.StapleFood)
                                .WithMany(sf => sf.EntreesWithCurrentStapleFood)
                                .OnDelete(DeleteBehavior.Restrict);
                        

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
                        modelBuilder.Entity<SupermarketVegetable> ().HasKey (sv =>
                                new { sv.SupermarketId, sv.VegeId });
                        modelBuilder.Entity<SupermarketMeat> ().HasKey (sm =>
                                new { sm.SupermarketId, sm.MeatId });
                        modelBuilder.Entity<SupermarketStapleFood> ().HasKey (ssf =>
                                new { ssf.SuperMarketId, ssf.StapleFoodId });
                        modelBuilder.Entity<EntreeIngredient>().HasKey(ei =>
                              new { ei.EntreeId, ei.IngredientId });
                }
        }
}
