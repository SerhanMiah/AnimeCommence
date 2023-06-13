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
            modelBuilder.Entity<Product>().HasData(
                // Your product seed data here...
                // First Seeding Data is Manga
                new Product
                {
                    ProductId = 1,
                    Name = "One Piece",
                    Description = "A manga about pirates in search of the ultimate treasure.",
                    Price = 10.99m,
                    Category = Category.Manga,
                    Genre = Genre.Shonen,
                    ReleaseDate = new DateTime(1997, 7, 22),
                    Publisher = "Shueisha",
                    Rating = 4.9f,
                    // Add image data if necessary
                },
                new Product
                {
                    ProductId = 2,
                    Name = "Naruto",
                    Description = "A manga about a ninja's journey to becoming the strongest in his village.",
                    Price = 9.99m,
                    Category = Category.Manga,
                    Genre = Genre.Shonen,
                    ReleaseDate = new DateTime(1999, 3, 3),
                    Publisher = "Shueisha",
                    Rating = 4.8f,
                    // Add image data if necessary
                },
                new Product
                {
                    ProductId = 3,
                    Name = "Bleach",
                    Description = "A manga about a teenager who becomes a soul reaper.",
                    Price = 10.99m,
                    Category = Category.Manga,
                    Genre = Genre.Shonen,
                    ReleaseDate = new DateTime(2001, 8, 20),
                    Publisher = "Shueisha",
                    Rating = 4.7f,
                    // Add image data if necessary
                },
                new Product
                {
                    ProductId = 4,
                    Name = "Death Note",
                    Description = "A manga about a high school student who discovers a notebook that allows him to kill anyone by writing their name in it.",
                    Price = 11.99m,
                    Category = Category.Manga,
                    Genre = Genre.Shonen,
                    ReleaseDate = new DateTime(2003, 12, 1),
                    Publisher = "Shueisha",
                    Rating = 4.9f,
                    // Add image data if necessary
                },
                new Product
                {
                    ProductId = 5,
                    Name = "Attack on Titan",
                    Description = "A manga about humanity's fight for survival against giant humanoid creatures.",
                    Price = 10.99m,
                    Category = Category.Manga,
                    Genre = Genre.Seinen,
                    ReleaseDate = new DateTime(2009, 9, 9),
                    Publisher = "Kodansha",
                    Rating = 4.8f,
                    // Add image data if necessary
                },
                // DVD Seeding Data
                        new Product
                {
                    ProductId = 6,
                    Name = "My Hero Academia Season 1",
                    Description = "The complete first season of My Hero Academia anime series on DVD.",
                    Price = 24.99m,
                    Category = Category.DVD,
                    Genre = Genre.Shonen,
                    ReleaseDate = new DateTime(2016, 5, 4),
                    Publisher = "Funimation",
                    Rating = 4.9f,
                },
                new Product
                {
                    ProductId = 7,
                    Name = "One Punch Man Season 1",
                    Description = "The complete first season of One Punch Man anime series on DVD.",
                    Price = 19.99m,
                    Category = Category.DVD,
                    Genre = Genre.Seinen,
                    ReleaseDate = new DateTime(2015, 7, 1),
                    Publisher = "Viz Media",
                    Rating = 4.8f,
                },
                new Product
                {
                    ProductId = 8,
                    Name = "Demon Slayer: Kimetsu no Yaiba Season 1",
                    Description = "The complete first season of Demon Slayer: Kimetsu no Yaiba anime series on DVD.",
                    Price = 24.99m,
                    Category = Category.DVD,
                    Genre = Genre.Shonen,
                    ReleaseDate = new DateTime(2019, 4, 6),
                    Publisher = "Aniplex",
                    Rating = 4.9f,
                },
                new Product
                {
                    ProductId = 9,
                    Name = "Attack on Titan Season 1",
                    Description = "The complete first season of Attack on Titan anime series on DVD.",
                    Price = 29.99m,
                    Category = Category.DVD,
                    Genre = Genre.Seinen,
                    ReleaseDate = new DateTime(2013, 4, 7),
                    Publisher = "Funimation",
                    Rating = 4.8f,
                },
                new Product
                {
                    ProductId = 10,
                    Name = "Naruto Shippuden Complete Series",
                    Description = "The complete series of Naruto Shippuden anime on DVD.",
                    Price = 199.99m,
                    Category = Category.DVD,
                    Genre = Genre.Shonen,
                    ReleaseDate = new DateTime(2017, 6, 1),
                    Publisher = "Viz Media",
                    Rating = 4.7f,
                },
                // Merchandise for anime theme seed
                new Product
                {
                    ProductId = 11,
                    Name = "One Piece Straw Hat",
                    Description = "Straw Hat of the iconic Monkey D. Luffy from One Piece.",
                    Price = 19.99m,
                    Category = Category.Merchandise,
                    Genre = Genre.Shonen,
                    ReleaseDate = new DateTime(2023, 1, 10),
                    Publisher = "Toei Animation",
                    Rating = 4.9f,
                },
                new Product
                {
                    ProductId = 12,
                    Name = "Naruto Akatsuki Cloak",
                    Description = "Cloak worn by the members of Akatsuki from Naruto.",
                    Price = 59.99m,
                    Category = Category.Merchandise,
                    Genre = Genre.Shonen,
                    ReleaseDate = new DateTime(2023, 2, 15),
                    Publisher = "Studio Pierrot",
                    Rating = 4.8f,
                },
                new Product
                {
                    ProductId = 13,
                    Name = "Attack on Titan Survey Corps Jacket",
                    Description = "Survey Corps Jacket from Attack on Titan.",
                    Price = 49.99m,
                    Category = Category.Merchandise,
                    Genre = Genre.Seinen,
                    ReleaseDate = new DateTime(2023, 3, 20),
                    Publisher = "Wit Studio",
                    Rating = 4.7f,
                },
                new Product
                {
                    ProductId = 14,
                    Name = "Fullmetal Alchemist Pocket Watch",
                    Description = "Pocket watch used by the State Alchemists in Fullmetal Alchemist.",
                    Price = 29.99m,
                    Category = Category.Merchandise,
                    Genre = Genre.Shonen,
                    ReleaseDate = new DateTime(2023, 4, 25),
                    Publisher = "Bones",
                    Rating = 4.9f,
                },
                new Product
                {
                    ProductId = 15,
                    Name = "Death Note Notebook",
                    Description = "Replica of the Death Note used in the Death Note series.",
                    Price = 14.99m,
                    Category = Category.Merchandise,
                    Genre = Genre.Shonen,
                    ReleaseDate = new DateTime(2023, 5, 30),
                    Publisher = "Madhouse",
                    Rating = 4.8f,
                }
            );
                // Second part Seeding Data is DVD
        
        }

        private void SeedImages(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Image>().HasData(
                // image seeding data here...
                // Manga
                new Image
                {
                    ImageId = 1,
                    ImageUrl = "https://static.wikia.nocookie.net/onepiece/images/c/c6/Volume_100.png/revision/latest?cb=20210903160940",
                    ProductId = 1  
                },
                new Image
                {
                    ImageId = 2,
                    ImageUrl = "https://d28hgpri8am2if.cloudfront.net/book_images/onix/cvr9781421564609/one-piece-vol-70-9781421564609_hr.jpg",
                    ProductId = 1  // Corresponding ProductId
                },
                new Image
                {
                    ImageId = 3,
                    ImageUrl = "https://img.asmedia.epimg.net/resizer/0AAWhRs-18LkHLrC1Zp3X1c2y9Y=/1472x828/cloudfront-eu-central-1.images.arcpublishing.com/diarioas/7FLY3ULLSRH2VCC3DDTEQDXMKI.jpg",
                    ProductId = 1  // Corresponding ProductId
                },
                new Image
                {
                    ImageId = 4,
                    ImageUrl = "https://your-url.com/death-note.jpg",
                    ProductId = 4  // Corresponding ProductId
                },
                new Image
                {
                    ImageId = 5,
                    ImageUrl = "https://your-url.com/attack-on-titan.jpg",
                    ProductId = 5  // Corresponding ProductId
                },
                // DVD Image Section
                   new Image
                {
                    ImageId = 6,
                    ImageUrl = "https://your-url.com/FullMetal_Alchemist_Brotherhood_DVD.jpg",
                    ProductId = 6
                },
                new Image
                {
                    ImageId = 7,
                    ImageUrl = "https://your-url.com/Death_Note_DVD.jpg",
                    ProductId = 7
                },
                new Image
                {
                    ImageId = 8,
                    ImageUrl = "https://your-url.com/Attack_on_Titan_DVD.jpg",
                    ProductId = 8
                },
                new Image
                {
                    ImageId = 9,
                    ImageUrl = "https://your-url.com/Naruto_Shippuden_DVD.jpg",
                    ProductId = 9
                },
                new Image
                {
                    ImageId = 10,
                    ImageUrl = "https://your-url.com/Demon_Slayer_DVD.jpg",
                    ProductId = 10
                },
                // Merchandise Image
                 new Image
                {
                    ImageId = 21,
                    ImageUrl = "https://example.com/one-piece-hat.jpg",
                    ProductId = 11  // Corresponding ProductId
                },
                new Image
                {
                    ImageId = 22,
                    ImageUrl = "https://example.com/naruto-akatsuki-cloak.jpg",
                    ProductId = 12  // Corresponding ProductId
                },
                new Image
                {
                    ImageId = 23,
                    ImageUrl = "https://example.com/aot-survey-corps-jacket.jpg",
                    ProductId = 13  // Corresponding ProductId
                },
                new Image
                {
                    ImageId = 24,
                    ImageUrl = "https://example.com/fullmetal-alchemist-watch.jpg",
                    ProductId = 14  // Corresponding ProductId
                },
                new Image
                {
                    ImageId = 25,
                    ImageUrl = "https://example.com/death-note-notebook.jpg",
                    ProductId = 15  // Corresponding ProductId
                }
            );
            
        }
    }
}
