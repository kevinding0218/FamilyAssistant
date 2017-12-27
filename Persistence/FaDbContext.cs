using FamilyAssistant.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyAssistant.Persistence
{
    public class FaDbContext : DbContext
    {
        public FaDbContext(DbContextOptions<FaDbContext> options)
        : base(options)
        {

        }

        public DbSet<Entree> Entrees { get; set; }
        public DbSet<Vegetable> Vegetables { get; set; }
        public DbSet<Meat> Meats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          //One to One
          //modelBuilder.Entity<Entree>()
          //  .HasOne(e => e.BaseOption)
          //  .WithOne(bo => bo.Entree)
          //  .HasForeignKey<Entree>(e => e.BaseOptionId);
          //Many to Many
          modelBuilder.Entity<EntreeMeat>().HasKey(em =>
                  new { em.EntreeId, em.MeatId });
          modelBuilder.Entity<EntreeVege>().HasKey(ev =>
                  new { ev.EntreeId, ev.VegeId });
        }
  }
}
