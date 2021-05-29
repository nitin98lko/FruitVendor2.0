using FruitUserApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitUserApi.Data
{
    public class FruitVendorContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=FruitBasketDbms;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cart>()
           .HasOne<Author>(sc => sc.author)
           .WithMany(s => s.CartRel)
           .HasForeignKey(sc => sc.aId);


            modelBuilder.Entity<Cart>()
           .HasOne<Fruit>(sc => sc.fruit)
           .WithMany(s => s.CartRel)
           .HasForeignKey(sc => sc.fId);

        }
        public DbSet<Fruit> Fruits { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Author> Authers { get; set; }


       
        public DbSet<Order> Orders { get; set; }

       

    }
}
