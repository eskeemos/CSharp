using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Tables
{
    public class DbConfig : DbContext
    {
        private readonly string conString = "Data Source=DESKTOP-DABF71C;Initial Catalog=db_Restaurant;Integrated Security=True";
        public DbSet<Restaurant> restaurants { get; set; }
        public DbSet<Address> addresses { get; set; }
        public DbSet<Dish> dishes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Restaurant>()
                .Property((r) => r.name)
                .IsRequired()
                .HasMaxLength(25);
            modelBuilder.Entity<Dish>()
                .Property((d) => d.name)
                .IsRequired();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(conString);
        }

    }
}
