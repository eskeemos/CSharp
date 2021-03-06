using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Tables
{
    public class RestaurantDbContext : DbContext
    {
        private readonly string conString = "Data Source=DESKTOP-DABF71C;Initial Catalog=db_Restaurant;Integrated Security=True";
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Dish> Dishes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Restaurant>()
                .Property((r) => r.Name)
                .IsRequired()
                .HasMaxLength(25);
            modelBuilder.Entity<Dish>()
                .Property((d) => d.Name)
                .IsRequired();
            modelBuilder.Entity<Address>()
                .Property((a) => a.City)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<Address>()
               .Property((a) => a.Street)
               .IsRequired()
               .HasMaxLength(50);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(conString);
        }

    }
}
