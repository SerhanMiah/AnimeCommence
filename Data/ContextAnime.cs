using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimeShop.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AnimeShop.Data
{
    public class ContextAnime : IdentityDbContext<ApplicationUser>
    {
        public ContextAnime(DbContextOptions<ContextAnime> options)
            : base(options)
        {
            Products = null!;
            Orders = null!;
            OrderItems = null!;
            Reviews = null!;
            ShoppingCartItems = null!;
            Images = null!;
        }


            public DbSet<Product> Products { get; set; }

            public DbSet<Image> Images { get; set; }
            public DbSet<Order>? Orders { get; set; }
            public DbSet<OrderItem>? OrderItems { get; set; }
            public DbSet<Review>? Reviews { get; set; }
            public DbSet<ShoppingCartItem>? ShoppingCartItems { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .Property(p => p.Category)
                .HasConversion<string>();

            modelBuilder.Entity<Product>()
                .Property(p => p.Genre)
                .HasConversion<string>();

            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18, 2)"); 


            SeedProducts(modelBuilder);
            SeedImages(modelBuilder);
        }
        
        // Seeding data for Products
        private void SeedProducts(ModelBuilder modelBuilder)
        {
        }


        // Seeding Data for Images 
        private void SeedImages(ModelBuilder modelBuilder)
        {

        }

    }
}
