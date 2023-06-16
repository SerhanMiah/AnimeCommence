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
      // Your product seed data here...
      modelBuilder.Entity<Product>().HasData(
    // seeding Data DVD
    new Product
    {
      ProductId = 1,
      Name = "One Piece Season 1",
      Description = "Monkey D. Luffy wants to become the King of all pirates.",
      Price = 29.99m,
      Category = Category.DVD,
      Genre = Genre.Shonen,
      ReleaseDate = new DateTime(1999, 10, 20),
      Publisher = "Toei Animation",
      Rating = 4.9f,
      InStock = true,
      Duration = 750,
      Region = "Region 1",
      Subtitles = "English",
      // Adding new fields
      Artist = "Eiichiro Oda",
      Author = "Eiichiro Oda",
      Pages = 200,
      Language = "English",
      ISBN = "123-4567891234",
      Size = "Medium",
      Color = "Blue",
      Quantity = 100,
      Manufacturer = "Toei Animation",
      Platform = "DVD",
      Studio = "Toei Animation",
      TrailerUrl = "https://www.youtube.com/watch?v=UTMoDHvgaJk"
    },
    new Product
    {
      ProductId = 2,
      Name = "Naruto Box Set 1",
      Description = "Immerse yourself in the thrilling world of Naruto with the first box set of the iconic anime series on DVD. This box set includes the exhilarating episodes from the early seasons, introducing you to the epic journey of Naruto Uzumaki as he aspires to become the strongest ninja in his village.",
      Price = 49.99m,
      Category = Category.DVD,
      Genre = Genre.Shonen,
      ReleaseDate = new DateTime(2005, 1, 1),
      Publisher = "Viz Media",
      Rating = 4.8f,
      InStock = true,
      Duration = 840,
      Region = "Region 1",
      Subtitles = "English"

    },
    new Product
    {
      ProductId = 3,
      Name = "Bleach Complete Series",
      Description = "The complete series of Bleach anime on DVD.",
      Price = 149.99m,
      Category = Category.DVD,
      Genre = Genre.Shonen,
      ReleaseDate = new DateTime(2004, 10, 5),
      Publisher = "Viz Media",
      Rating = 4.7f,
      InStock = true,
      Duration = 2700,
      Region = "Region 1",
      Subtitles = "English"
    },
    new Product
    {
      ProductId = 4,
      Name = "Dragon Ball Z: Season 1",
      Description = "The complete first season of Dragon Ball Z anime series on DVD.",
      Price = 34.99m,
      Category = Category.DVD,
      Genre = Genre.Shonen,
      ReleaseDate = new DateTime(1989, 4, 26),
      Publisher = "Funimation",
      Rating = 4.9f,
      InStock = true,
      Duration = 900,
      Region = "Region 1",
      Subtitles = "English"
    },
    new Product
    {
      ProductId = 5,
      Name = "My Hero Academia Season 1",
      Description = "The complete first season of My Hero Academia anime series on DVD.",
      Price = 24.99m,
      Category = Category.DVD,
      Genre = Genre.Shonen,
      ReleaseDate = new DateTime(2016, 4, 3),
      Publisher = "Funimation",
      Rating = 4.8f,
      InStock = true,
      Duration = 325,
      Region = "Region 1",
      Subtitles = "English"
    },
    new Product
    {
      ProductId = 6,
      Name = "One Punch Man Season 1",
      Description = "The complete first season of One Punch Man anime series on DVD.",
      Price = 19.99m,
      Category = Category.DVD,
      Genre = Genre.Shonen,
      ReleaseDate = new DateTime(2015, 10, 5),
      Publisher = "Viz Media",
      Rating = 4.8f,
      InStock = true,
      Duration = 300,
      Region = "Region 1",
      Subtitles = "English"
    },
    new Product
    {
      ProductId = 7,
      Name = "Demon Slayer Season 1",
      Description = "The complete first season of Demon Slayer anime series on DVD.",
      Price = 39.99m,
      Category = Category.DVD,
      Genre = Genre.Shonen,
      ReleaseDate = new DateTime(2019, 4, 6),
      Publisher = "Aniplex",
      Rating = 4.9f,
      InStock = true,
      Duration = 625,
      Region = "Region 1",
      Subtitles = "English"
    },
    new Product
    {
      ProductId = 8,
      Name = "Attack on Titan Season 1",
      Description = "The complete first season of Attack on Titan anime series on DVD.",
      Price = 29.99m,
      Category = Category.DVD,
      Genre = Genre.Shonen,
      ReleaseDate = new DateTime(2013, 4, 7),
      Publisher = "Funimation",
      Rating = 4.8f,
      InStock = true,
      Duration = 625,
      Region = "Region 1",
      Subtitles = "English"
    },
    new Product
    {
      ProductId = 9,
      Name = "Hunter x Hunter Box Set 1",
      Description = "The first box set of Hunter x Hunter anime series on DVD.",
      Price = 59.99m,
      Category = Category.DVD,
      Genre = Genre.Shonen,
      ReleaseDate = new DateTime(1999, 10, 16),
      Publisher = "Viz Media",
      Rating = 4.7f,
      InStock = true,
      Duration = 675,
      Region = "Region 1",
      Subtitles = "English"
    },
    new Product
    {
      ProductId = 10,
      Name = "Fairy Tail Collection 1",
      Description = "The first collection of Fairy Tail anime series on DVD.",
      Price = 39.99m,
      Category = Category.DVD,
      Genre = Genre.Shonen,
      ReleaseDate = new DateTime(2009, 4, 4),
      Publisher = "Funimation",
      Rating = 4.6f,
      InStock = true,
      Duration = 600,
      Region = "Region 1",
      Subtitles = "English"
    },
    new Product
    {
      ProductId = 11,
      Name = "Yu Yu Hakusho: Season 1",
      Description = "The complete first season of Yu Yu Hakusho anime series on DVD.",
      Price = 34.99m,
      Category = Category.DVD,
      Genre = Genre.Shonen,
      ReleaseDate = new DateTime(1992, 10, 10),
      Publisher = "Funimation",
      Rating = 4.9f,
      InStock = true,
      Duration = 575,
      Region = "Region 1",
      Subtitles = "English"
    },
    new Product
    {
      ProductId = 12,
      Name = "Black Clover Season 1",
      Description = "The complete first season of Black Clover anime series on DVD.",
      Price = 29.99m,
      Category = Category.DVD,
      Genre = Genre.Shonen,
      ReleaseDate = new DateTime(2017, 10, 3),
      Publisher = "Crunchyroll",
      Rating = 4.7f,
      InStock = true,
      Duration = 625,
      Region = "Region 1",
      Subtitles = "English"
    },
    new Product
    {
      ProductId = 13,
      Name = "Dragon Ball Super: Part 1",
      Description = "The first part of Dragon Ball Super anime series on DVD.",
      Price = 39.99m,
      Category = Category.DVD,
      Genre = Genre.Shonen,
      ReleaseDate = new DateTime(2015, 7, 5),
      Publisher = "Funimation",
      Rating = 4.8f,
      InStock = true,
      Duration = 325,
      Region = "Region 1",
      Subtitles = "English"
    },
    new Product
    {
      ProductId = 14,
      Name = "Fullmetal Alchemist: Brotherhood Complete Collection",
      Description = "The complete collection of Fullmetal Alchemist: Brotherhood anime series on DVD.",
      Price = 99.99m,
      Category = Category.DVD,
      Genre = Genre.Shonen,
      ReleaseDate = new DateTime(2009, 4, 5),
      Publisher = "Aniplex",
      Rating = 4.9f,
      InStock = true,
      Duration = 2750,
      Region = "Region 1",
      Subtitles = "English"
    },
    new Product
    {
      ProductId = 15,
      Name = "Sword Art Online: Season 1",
      Description = "The complete first season of Sword Art Online anime series on DVD.",
      Price = 34.99m,
      Category = Category.DVD,
      Genre = Genre.Shonen,
      ReleaseDate = new DateTime(2012, 7, 7),
      Publisher = "Aniplex",
      Rating = 4.8f,
      InStock = true,
      Duration = 600,
      Region = "Region 1",
      Subtitles = "English"
    },
    new Product
    {
      ProductId = 16,
      Name = "Fruits Basket Season 1",
      Description = "The complete first season of Fruits Basket anime series on DVD.",
      Price = 29.99m,
      Category = Category.DVD,
      Genre = Genre.Shojo,
      ReleaseDate = new DateTime(2001, 7, 5),
      Publisher = "Funimation",
      Rating = 4.8f,
      InStock = true,
      Duration = 600,
      Region = "Region 1",
      Subtitles = "English"
    },
    new Product
    {
      ProductId = 17,
      Name = "Your Lie in April",
      Description = "A DVD collection of the Your Lie in April anime series.",
      Price = 39.99m,
      Category = Category.DVD,
      Genre = Genre.Shojo,
      ReleaseDate = new DateTime(2014, 10, 9),
      Publisher = "Aniplex",
      Rating = 4.9f,
      InStock = true,
      Duration = 550,
      Region = "Region 1",
      Subtitles = "English"
    },
    new Product
    {
      ProductId = 18,
      Name = "Nana Complete Collection",
      Description = "The complete collection of the Nana anime series on DVD.",
      Price = 99.99m,
      Category = Category.DVD,
      Genre = Genre.Shojo,
      ReleaseDate = new DateTime(2006, 4, 5),
      Publisher = "Viz Media",
      Rating = 4.7f,
      InStock = true,
      Duration = 1150,
      Region = "Region 1",
      Subtitles = "English"
    },
    new Product
    {
      ProductId = 19,
      Name = "Princess Tutu",
      Description = "A DVD set of the Princess Tutu anime series.",
      Price = 29.99m,
      Category = Category.DVD,
      Genre = Genre.Shojo,
      ReleaseDate = new DateTime(2002, 8, 16),
      Publisher = "ADV Films",
      Rating = 4.8f,
      InStock = true,
      Duration = 650,
      Region = "Region 1",
      Subtitles = "English"
    },
    new Product
    {
      ProductId = 20,
      Name = "Kimi ni Todoke Season 1",
      Description = "The complete first season of the Kimi ni Todoke anime series on DVD.",
      Price = 34.99m,
      Category = Category.DVD,
      Genre = Genre.Shojo,
      ReleaseDate = new DateTime(2009, 10, 6),
      Publisher = "NIS America",
      Rating = 4.9f,
      InStock = true,
      Duration = 625,
      Region = "Region 1",
      Subtitles = "English"
    },

    // DVD seed data for Seinen genre
    new Product
    {
      ProductId = 21,
      Name = "Attack on Titan Season 1",
      Description = "The complete first season of Attack on Titan anime series on DVD.",
      Price = 29.99m,
      Category = Category.DVD,
      Genre = Genre.Seinen,
      ReleaseDate = new DateTime(2013, 4, 7),
      Publisher = "Funimation",
      Rating = 4.8f,
      InStock = true,
      Duration = 625,
      Region = "Region 1",
      Subtitles = "English"
    },
    new Product
    {
      ProductId = 22,
      Name = "Tokyo Ghoul Season 1",
      Description = "The complete first season of Tokyo Ghoul anime series on DVD.",
      Price = 24.99m,
      Category = Category.DVD,
      Genre = Genre.Seinen,
      ReleaseDate = new DateTime(2014, 7, 4),
      Publisher = "Funimation",
      Rating = 4.7f,
      InStock = true,
      Duration = 300,
      Region = "Region 1",
      Subtitles = "English"
    },
    new Product
    {
      ProductId = 23,
      Name = "Death Note",
      Description = "A DVD collection of the Death Note anime series.",
      Price = 39.99m,
      Category = Category.DVD,
      Genre = Genre.Seinen,
      ReleaseDate = new DateTime(2006, 10, 3),
      Publisher = "Viz Media",
      Rating = 4.9f,
      InStock = true,
      Duration = 675,
      Region = "Region 1",
      Subtitles = "English"
    },
    new Product
    {
      ProductId = 24,
      Name = "Cowboy Bebop Complete Series",
      Description = "The complete series of the Cowboy Bebop anime on DVD.",
      Price = 49.99m,
      Category = Category.DVD,
      Genre = Genre.Seinen,
      ReleaseDate = new DateTime(1998, 4, 3),
      Publisher = "Funimation",
      Rating = 4.8f,
      InStock = true,
      Duration = 1175,
      Region = "Region 1",
      Subtitles = "English"
    },
    new Product
    {
      ProductId = 25,
      Name = "Parasyte -the maxim- Complete Collection",
      Description = "The complete collection of the Parasyte -the maxim- anime series on DVD.",
      Price = 59.99m,
      Category = Category.DVD,
      Genre = Genre.Seinen,
      ReleaseDate = new DateTime(2014, 10, 9),
      Publisher = "Sentai Filmworks",
      Rating = 4.7f,
      InStock = true,
      Duration = 625,
      Region = "Region 1",
      Subtitles = "English"
    },

    // DVD seed data for Josei genre
    new Product
    {
      ProductId = 26,
      Name = "Nodame Cantabile Complete Series",
      Description = "The complete series of the Nodame Cantabile anime on DVD.",
      Price = 79.99m,
      Category = Category.DVD,
      Genre = Genre.Josei,
      ReleaseDate = new DateTime(2007, 1, 12),
      Publisher = "Geneon Universal Entertainment",
      Rating = 4.8f,
      InStock = true,
      Duration = 1325,
      Region = "Region 1",
      Subtitles = "English"
    },
    new Product
    {
      ProductId = 27,
      Name = "Honey and Clover",
      Description = "A DVD collection of the Honey and Clover anime series.",
      Price = 49.99m,
      Category = Category.DVD,
      Genre = Genre.Josei,
      ReleaseDate = new DateTime(2005, 4, 15),
      Publisher = "Viz Media",
      Rating = 4.7f,
      InStock = true,
      Duration = 850,
      Region = "Region 1",
      Subtitles = "English"
    },
    new Product
    {
      ProductId = 28,
      Name = "Chihayafuru Season 1",
      Description = "The complete first season of the Chihayafuru anime series on DVD.",
      Price = 39.99m,
      Category = Category.DVD,
      Genre = Genre.Josei,
      ReleaseDate = new DateTime(2011, 10, 5),
      Publisher = "Madhouse",
      Rating = 4.9f,
      InStock = true,
      Duration = 625,
      Region = "Region 1",
      Subtitles = "English"
    },
    new Product
    {
      ProductId = 29,
      Name = "Nana Complete Collection",
      Description = "The complete collection of the Nana anime series on DVD.",
      Price = 99.99m,
      Category = Category.DVD,
      Genre = Genre.Josei,
      ReleaseDate = new DateTime(2006, 4, 5),
      Publisher = "Viz Media",
      Rating = 4.7f,
      InStock = true,
      Duration = 1150,
      Region = "Region 1",
      Subtitles = "English"
    },
    new Product
    {
      ProductId = 30,
      Name = "Paradise Kiss",
      Description = "A DVD set of the Paradise Kiss anime series.",
      Price = 29.99m,
      Category = Category.DVD,
      Genre = Genre.Josei,
      ReleaseDate = new DateTime(2005, 10, 13),
      Publisher = "Geneon Universal Entertainment",
      Rating = 4.8f,
      InStock = true,
      Duration = 325,
      Region = "Region 1",
      Subtitles = "English"
    },

    // DVD seed data for Kodomomuke genre
    new Product
    {
      ProductId = 31,
      Name = "Pokémon Indigo League",
      Description = "The complete Indigo League season of the Pokémon anime series on DVD.",
      Price = 39.99m,
      Category = Category.DVD,
      Genre = Genre.Kodomomuke,
      ReleaseDate = new DateTime(1997, 4, 1),
      Publisher = "Viz Media",
      Rating = 4.8f,
      InStock = true,
      Duration = 1175,
      Region = "Region 1",
      Subtitles = "English"
    },
    new Product
    {
      ProductId = 32,
      Name = "Doraemon: Gadget Cat from the Future",
      Description = "A DVD collection of Doraemon episodes.",
      Price = 29.99m,
      Category = Category.DVD,
      Genre = Genre.Kodomomuke,
      ReleaseDate = new DateTime(1979, 4, 2),
      Publisher = "Shin-Ei Animation",
      Rating = 4.7f,
      InStock = true,
      Duration = 325,
      Region = "Region 1",
      Subtitles = "English"
    },
    new Product
    {
      ProductId = 33,
      Name = "Sailor Moon Season 1",
      Description = "The complete first season of the Sailor Moon anime series on DVD.",
      Price = 49.99m,
      Category = Category.DVD,
      Genre = Genre.Kodomomuke,
      ReleaseDate = new DateTime(1992, 3, 7),
      Publisher = "Viz Media",
      Rating = 4.9f,
      InStock = true,
      Duration = 625,
      Region = "Region 1",
      Subtitles = "English"
    },
    new Product
    {
      ProductId = 34,
      Name = "Yo-kai Watch Season 1",
      Description = "The complete first season of the Yo-kai Watch anime series on DVD.",
      Price = 29.99m,
      Category = Category.DVD,
      Genre = Genre.Kodomomuke,
      ReleaseDate = new DateTime(2014, 1, 8),
      Publisher = "Level-5",
      Rating = 4.8f,
      InStock = true,
      Duration = 525,
      Region = "Region 1",
      Subtitles = "English"
    },
    new Product
    {
      ProductId = 35,
      Name = "Detective Conan Season 1",
      Description = "The complete first season of the Detective Conan anime series on DVD.",
      Price = 39.99m,
      Category = Category.DVD,
      Genre = Genre.Kodomomuke,
      ReleaseDate = new DateTime(1996, 1, 8),
      Publisher = "TMS Entertainment",
      Rating = 4.7f,
      InStock = true,
      Duration = 625,
      Region = "Region 1",
      Subtitles = "English"
    },

    // DVD seed data for Isekai genre
    new Product
    {
      ProductId = 36,
      Name = "Sword Art Online Season 1",
      Description = "The complete first season of Sword Art Online anime series on DVD.",
      Price = 34.99m,
      Category = Category.DVD,
      Genre = Genre.Isekai,
      ReleaseDate = new DateTime(2012, 7, 7),
      Publisher = "Aniplex",
      Rating = 4.8f,
      InStock = true,
      Duration = 600,
      Region = "Region 1",
      Subtitles = "English"
    },
    new Product
    {
      ProductId = 37,
      Name = "Overlord Season 1",
      Description = "The complete first season of Overlord anime series on DVD.",
      Price = 29.99m,
      Category = Category.DVD,
      Genre = Genre.Isekai,
      ReleaseDate = new DateTime(2015, 7, 7),
      Publisher = "Funimation",
      Rating = 4.7f,
      InStock = true,
      Duration = 325,
      Region = "Region 1",
      Subtitles = "English"
    },
    new Product
    {
      ProductId = 38,
      Name = "Re:Zero Season 1",
      Description = "The complete first season of Re:Zero anime series on DVD.",
      Price = 39.99m,
      Category = Category.DVD,
      Genre = Genre.Isekai,
      ReleaseDate = new DateTime(2016, 4, 4),
      Publisher = "Crunchyroll",
      Rating = 4.9f,
      InStock = true,
      Duration = 625,
      Region = "Region 1",
      Subtitles = "English"
    },
    new Product
    {
      ProductId = 39,
      Name = "Konosuba Season 1",
      Description = "The complete first season of Konosuba anime series on DVD.",
      Price = 24.99m,
      Category = Category.DVD,
      Genre = Genre.Isekai,
      ReleaseDate = new DateTime(2016, 1, 14),
      Publisher = "Crunchyroll",
      Rating = 4.8f,
      InStock = true,
      Duration = 300,
      Region = "Region 1",
      Subtitles = "English"
    },
    new Product
    {
      ProductId = 40,
      Name = "The Rising of the Shield Hero Season 1",
      Description = "The complete first season of The Rising of the Shield Hero anime series on DVD.",
      Price = 29.99m,
      Category = Category.DVD,
      Genre = Genre.Isekai,
      ReleaseDate = new DateTime(2019, 1, 9),
      Publisher = "Crunchyroll",
      Rating = 4.7f,
      InStock = true,
      Duration = 625,
      Region = "Region 1",
      Subtitles = "English"
    },
    new Product
    {
      ProductId = 41,
      Name = "Attack on Titan Hoodie",
      Description = "Hoodie featuring the Attack on Titan logo.",
      Price = 39.99m,
      Category = Category.Merchandise,
      Genre = Genre.Seinen,
      ReleaseDate = new DateTime(2009, 9, 9),
      Publisher = "Kodansha",
      Rating = 4.8f,
      InStock = true
    },
new Product
{
  ProductId = 42,
  Name = "My Hero Academia Keychain Set",
  Description = "Set of keychains featuring the characters from My Hero Academia.",
  Price = 14.99m,
  Category = Category.Merchandise,
  Genre = Genre.Shonen,
  ReleaseDate = new DateTime(2016, 4, 3),
  Publisher = "Funimation",
  Rating = 4.8f,
  InStock = true
},
new Product
{
  ProductId = 43,
  Name = "Naruto Headband",
  Description = "Authentic Naruto headband worn by the ninjas of the Hidden Leaf Village.",
  Price = 19.99m,
  Category = Category.Merchandise,
  Genre = Genre.Shonen,
  ReleaseDate = new DateTime(1999, 3, 3),
  Publisher = "Shueisha",
  Rating = 4.7f,
  InStock = true
},
new Product
{
  ProductId = 44,
  Name = "Demon Slayer T-Shirt",
  Description = "T-Shirt featuring the Demon Slayer logo.",
  Price = 24.99m,
  Category = Category.Merchandise,
  Genre = Genre.Shonen,
  ReleaseDate = new DateTime(2019, 4, 6),
  Publisher = "Aniplex",
  Rating = 4.9f,
  InStock = true
},
new Product
{
  ProductId = 45,
  Name = "Fairy Tail Backpack",
  Description = "Backpack featuring the Fairy Tail guild emblem.",
  Price = 39.99m,
  Category = Category.Merchandise,
  Genre = Genre.Shonen,
  ReleaseDate = new DateTime(2006, 8, 23),
  Publisher = "Kodansha",
  Rating = 4.7f,
  InStock = true
},
new Product
{
  ProductId = 46,
  Name = "Sailor Moon Plushies Set",
  Description = "Set of plushies featuring the characters from Sailor Moon.",
  Price = 29.99m,
  Category = Category.Merchandise,
  Genre = Genre.Shojo,
  ReleaseDate = new DateTime(1992, 3, 7),
  Publisher = "Kodansha",
  Rating = 4.8f,
  InStock = true
},
new Product
{
  ProductId = 47,
  Name = "Tokyo Ghoul Mug",
  Description = "Mug featuring the Tokyo Ghoul logo.",
  Price = 14.99m,
  Category = Category.Merchandise,
  Genre = Genre.Seinen,
  ReleaseDate = new DateTime(2011, 9, 8),
  Publisher = "Shueisha",
  Rating = 4.6f,
  InStock = true
},
new Product
{
  ProductId = 48,
  Name = "Attack on Titan Keychain",
  Description = "Keychain featuring the Attack on Titan Survey Corps emblem.",
  Price = 9.99m,
  Category = Category.Merchandise,
  Genre = Genre.Seinen,
  ReleaseDate = new DateTime(2009, 9, 9),
  Publisher = "Kodansha",
  Rating = 4.7f,
  InStock = true
},
new Product
{
  ProductId = 49,
  Name = "Haikyu!! Poster",
  Description = "Poster featuring the characters from Haikyu!!.",
  Price = 9.99m,
  Category = Category.Merchandise,
  Genre = Genre.Shonen,
  ReleaseDate = new DateTime(2012, 2, 20),
  Publisher = "Shueisha",
  Rating = 4.8f,
  InStock = true
},
new Product
{
  ProductId = 50,
  Name = "Your Lie in April Music Box",
  Description = "Music box playing the theme song from Your Lie in April.",
  Price = 34.99m,
  Category = Category.Merchandise,
  Genre = Genre.Shojo,
  ReleaseDate = new DateTime(2011, 4, 7),
  Publisher = "Kodansha",
  Rating = 4.9f,
  InStock = true
},
new Product
{
  ProductId = 51,
  Name = "Attack on Titan Hoodie",
  Description = "Hoodie featuring the Attack on Titan Survey Corps emblem.",
  Price = 49.99m,
  Category = Category.Apparel,
  Genre = Genre.Seinen,
  ReleaseDate = new DateTime(2009, 9, 9),
  Publisher = "Kodansha",
  Rating = 4.8f,
  InStock = true
},
new Product
{
  ProductId = 52,
  Name = "Naruto T-Shirt",
  Description = "T-Shirt featuring Naruto Uzumaki artwork.",
  Price = 19.99m,
  Category = Category.Apparel,
  Genre = Genre.Shonen,
  ReleaseDate = new DateTime(1999, 3, 3),
  Publisher = "Shueisha",
  Rating = 4.7f,
  InStock = true
},
new Product
{
  ProductId = 53,
  Name = "Sailor Moon Sweatshirt",
  Description = "Sweatshirt featuring the Sailor Moon logo.",
  Price = 34.99m,
  Category = Category.Apparel,
  Genre = Genre.Shojo,
  ReleaseDate = new DateTime(1992, 3, 7),
  Publisher = "Kodansha",
  Rating = 4.9f,
  InStock = true
},
new Product
{
  ProductId = 54,
  Name = "One Piece Cap",
  Description = "Cap featuring the One Piece Jolly Roger emblem.",
  Price = 14.99m,
  Category = Category.Apparel,
  Genre = Genre.Shonen,
  ReleaseDate = new DateTime(1997, 7, 22),
  Publisher = "Shueisha",
  Rating = 4.8f,
  InStock = true
},
new Product
{
  ProductId = 55,
  Name = "My Hero Academia Socks Set",
  Description = "Set of socks featuring characters from My Hero Academia.",
  Price = 9.99m,
  Category = Category.Apparel,
  Genre = Genre.Shonen,
  ReleaseDate = new DateTime(2014, 7, 7),
  Publisher = "Shueisha",
  Rating = 4.7f,
  InStock = true
}
      );
      // Add more seeding data if needed

    }


    private void SeedImages(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Image>().HasData(
          new Image
          {
            ImageId = 1,
            ImageUrl = "https://res.cloudinary.com/danedskby/image/upload/v1686843216/OnePiece/p12129031_b_h9_ab_okykpq.jpg",
            ProductId = 1
          },
          new Image
          {
            ImageId = 2,
            ImageUrl = "https://res.cloudinary.com/danedskby/image/upload/v1686843215/OnePiece/8776327_so_vfd2wj.jpg",
            ProductId = 1
          },
          new Image
          {
            ImageId = 3,
            ImageUrl = "https://res.cloudinary.com/danedskby/image/upload/v1686843215/OnePiece/v0qPfG_y7t3b7.jpg",
            ProductId = 1
          },
          new Image
          {
            ImageId = 4,
            ImageUrl = "https://res.cloudinary.com/danedskby/image/upload/v1686843215/OnePiece/one_piece_opening_1000.jpg_423682103_p8jcjq.webp",
            ProductId = 1
          },
          new Image
          {
            ImageId = 5,
            ImageUrl = "https://res.cloudinary.com/danedskby/image/upload/v1686843214/OnePiece/One-Piece-chapter-1_tgay9v.jpg",
            ProductId = 1
          },
          // Naruto image
          new Image
          {
            ImageId = 6,
            ImageUrl = "https://res.cloudinary.com/danedskby/image/upload/v1686923807/Naruto/naruto-vol-68-9781421576824_hr_rlrggo.jpg",
            ProductId = 2
          },
          new Image
          {
            ImageId = 7,
            ImageUrl = "https://res.cloudinary.com/danedskby/image/upload/v1686923807/Naruto/naruto1_visual_xziu06.webp",
            ProductId = 2
          },
          new Image
          {
            ImageId = 8,
            ImageUrl = "https://res.cloudinary.com/danedskby/image/upload/v1686923806/Naruto/b12b9782aa863b75cdbee3a35ab62bd2_fy0bob.jpg",
            ProductId = 2
          },
          new Image
          {
            ImageId = 9,
            ImageUrl = "https://res.cloudinary.com/danedskby/image/upload/v1686923806/Naruto/AAAABYxJFBDckfZw1YUEIPwyuIg43Kw_HUBLvnCcgdOlvvf5Nc90SF3HSAi5L8uLyBqjziKBY-kGD2wu2JAqVsdHVR0frb6qG26I_U5v_a9ihom.jpg",
            ProductId = 2
          },
          new Image
          {
            ImageId = 10,
            ImageUrl = "https://res.cloudinary.com/danedskby/image/upload/v1686923806/Naruto/Profil-Picture-Naruto-Shippuden-600x600_ycugfi.webp",
            ProductId = 2
          },
          new Image
          {
            ImageId = 11,
            ImageUrl = "https://res.cloudinary.com/danedskby/image/upload/v1686924055/Bleach/image-asset_hoalrl.jpg",
            ProductId = 3
          },
          new Image
          {
            ImageId = 12,
            ImageUrl = "https://res.cloudinary.com/danedskby/image/upload/v1686924055/Bleach/bleach-20th-anniversary-anime-return_cicuq1.jpg",
            ProductId = 3
          },
          new Image
          {
            ImageId = 13,
            ImageUrl = "https://res.cloudinary.com/danedskby/image/upload/v1686924055/Bleach/3f367-16729468481724_euq3zu.avif",
            ProductId = 3
          },
          new Image
          {
            ImageId = 14,
            ImageUrl = "https://res.cloudinary.com/danedskby/image/upload/v1686924055/Bleach/LzRDfFeNHeUCtpH-1600x900-noPad_pns11d.jpg",
            ProductId = 3
          },
          new Image
          {
            ImageId = 15,
            ImageUrl = "https://res.cloudinary.com/danedskby/image/upload/v1686924055/Bleach/LzRDfFeNHeUCtpH-1600x900-noPad_pns11d.jpg",
            ProductId = 3
          },
          new Image
          {
            ImageId = 16,
            ImageUrl = "https://cdn.vox-cdn.com/thumbor/6zsaqAYi7xeMcbhLW4MsxUN6NZs=/1400x1400/filters:format(jpeg)/cdn.vox-cdn.com/uploads/chorus_asset/file/3652050/wall6_wallpaper_1280x800.0.jpg",
            ProductId = 4 // Dragon Ball Z: Season 1
          },
          new Image
          {
            ImageId = 17,
            ImageUrl = "https://m.media-amazon.com/images/I/71iprqtljOL._AC_UF1000,1000_QL80_.jpg",
            ProductId = 4 // Dragon Ball Z: Season 1
          },
          new Image
          {
            ImageId = 18,
            ImageUrl = "https://e24joaz2t6m.exactdn.com/wp-content/uploads/2016/07/DragonBallZ-Season1-a.jpg",
            ProductId = 4 // Dragon Ball Z: Season 1
          },
          new Image
          {
            ImageId = 19,
            ImageUrl = "https://www.crunchyroll.com/imgsrv/display/thumbnail/1200x675/catalog/crunchyroll/36bdc5ea4443cd8e42f22ec7d3884cbb.jpe",
            ProductId = 4 // Dragon Ball Z: Season 1
          },
          new Image
          {
            ImageId = 20,
            ImageUrl = "https://assets.mycast.io/posters/dragon-ball-z-netflix-season-1-saiyan-saga-fan-casting-poster-144948-large.jpg?1636572989",
            ProductId = 4 // Dragon Ball Z: Season 1
          },
          new Image
          {
            ImageId = 21,
            ImageUrl = "https://m.media-amazon.com/images/I/81mOMGHVHdL._AC_UF1000,1000_QL80_.jpg",
            ProductId = 5 // My Hero Academia Season 1
          },
          new Image
          {
            ImageId = 22,
            ImageUrl = "https://i0.wp.com/boldcanon.com/wp-content/uploads/2019/09/mv5bnmqzyme2mgetzjk4ys00ymvjlwewzwmtodrkmjc4mtm5n2i3xkeyxkfqcgdeqxvyntayodkwoq4040._v1_-e1567632423552.jpg?resize=1000%2C720&ssl=1",
            ProductId = 5 // My Hero Academia Season 1
          },
          new Image
          {
            ImageId = 23,
            ImageUrl = "https://twinfinite.net/wp-content/uploads/2022/04/my-hero-academia-season-1-1.jpg?fit=1200%2C675",
            ProductId = 5 // My Hero Academia Season 1
          },
          new Image
          {
            ImageId = 24,
            ImageUrl = "https://www.screenspy.com/wp-content/uploads/2022/04/Screenshotter-MyHeroAcademiaE7DekuvsKacchan-1943.jpg",
            ProductId = 5 // My Hero Academia Season 1
          },
          new Image
          {
            ImageId = 25,
            ImageUrl = "https://i0.wp.com/butwhytho.net/wp-content/uploads/2022/11/My-Hero-Academia-Episode-122-But-Why-Tho-1.jpg?fit=800%2C410&ssl=1",
            ProductId = 5 // My Hero Academia Season 1
          },
          new Image
          {
            ImageId = 26,
            ImageUrl = "https://static.wikia.nocookie.net/onepunchman/images/c/cd/One-Punch_Man_TV_Anime_Key_Visual.png/revision/latest?cb=20220818034817",
            ProductId = 6 // One Punch Man Season 1
          },
          new Image
          {
            ImageId = 27,
            ImageUrl = "https://img4.hulu.com/user/v3/artwork/34ebf58e-5a2a-4efa-8e4d-fb16039a3051?base_image_bucket_name=image_manager&base_image=ec6b707a-85c2-4d7c-9e3d-f9adf79004e3&size=600x338&format=jpeg",
            ProductId = 6 // One Punch Man Season 1
          },
          new Image
          {
            ImageId = 28,
            ImageUrl = "https://e0.pxfuel.com/wallpapers/84/241/desktop-wallpaper-one-punch-man-best-season-1-funny-saitama.jpg",
            ProductId = 6 // One Punch Man Season 1
          },
          new Image
          {
            ImageId = 29,
            ImageUrl = "https://static.wikia.nocookie.net/onepunchman/images/9/99/Puri-Puri_Prisoner_vs._Deep_Sea_King.png/revision/latest?cb=20160101201537",
            ProductId = 6 // One Punch Man Season 1
          },
          new Image
          {
            ImageId = 30,
            ImageUrl = "https://images-na.ssl-images-amazon.com/images/S/pv-target-images/c5ef21697095ba7cc0bbec2c96dafca98119bac23349e0a8baac7d78a4107c07._RI_TTW_SX720_FMjpg_.jpg",
            ProductId = 6 // One Punch Man Season 1
          },
          new Image
          {
            ImageId = 31,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BYTIxNjk3YjItYmYzMC00ZTdmLTk0NGUtZmNlZTA0NWFkZDMwXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_UY1200_CR85,0,630,1200_AL_.jpg",
            ProductId = 7 // Demon Slayer Season 1
          },
          new Image
          {
            ImageId = 32,
            ImageUrl = "https://images.immediate.co.uk/production/volatile/sites/3/2022/10/Demon-Slayer-Attack-Different-Swords-8836587.jpg",
            ProductId = 7 // Demon Slayer Season 1
          },
          new Image
          {
            ImageId = 33,
            ImageUrl = "https://www.hindustantimes.com/ht-img/img/2023/04/05/1600x900/Demon_slayer_season_2_recap_1680711861129_1680711892122_1680711892122.png",
            ProductId = 7 // Demon Slayer Season 1
          },
          new Image
          {
            ImageId = 34,
            ImageUrl = "https://cdn.vox-cdn.com/thumbor/JBMeqrjWveSK05wPniHAOUzErrI=/1400x1050/filters:format(jpeg)/cdn.vox-cdn.com/uploads/chorus_asset/file/24423451/Demon_Slayer_World_Tour_KV_ENG.jpg",
            ProductId = 7 // Demon Slayer Season 1
          },
          new Image
          {
            ImageId = 35,
            ImageUrl = "https://cdn.animenewsnetwork.com/thumbnails/max650x650/cms/news.6/192798/kimetsu_worldtour.jpg",
            ProductId = 7 // Demon Slayer Season 1
          },
          new Image
          {
            ImageId = 36,
            ImageUrl = "https://flxt.tmsimg.com/assets/p10873160_b1t_v8_aa.jpg",
            ProductId = 8 // Attack on Titan Season 1
          },
          new Image
          {
            ImageId = 37,
            ImageUrl = "https://2danicritic.github.io/index_files/ReviewImages/review_Attack_on_Titan_-_Season_12.jpg",
            ProductId = 8 // Attack on Titan Season 1
          },
          new Image
          {
            ImageId = 38,
            ImageUrl = "https://static.wikia.nocookie.net/shingekinokyojin/images/8/83/Eren_vs_Colossal_Titan.png/revision/latest?cb=20170623113218",
            ProductId = 8 // Attack on Titan Season 1
          },
          new Image
          {
            ImageId = 39,
            ImageUrl = "https://static.wikia.nocookie.net/shingekinokyojin/images/8/83/Eren_vs_Colossal_Titan.png/revision/latest?cb=20170623113218",
            ProductId = 8 // Attack on Titan Season 1
          },
          new Image
          {
            ImageId = 40,
            ImageUrl = "https://i0.wp.com/www.screenspy.com/wp-content/uploads/2022/07/attack-on-titan-s1-e25-2.png?ssl=1",
            ProductId = 8 // Attack on Titan Season 1
          },
          new Image
          {
            ImageId = 41,
            ImageUrl = "https://dw9to29mmj727.cloudfront.net/promo/2016/6231-SeriesHeaders_HxH_2000x800.jpg",
            ProductId = 9 // Hunter x Hunter Box Set 1
          },
          new Image
          {
            ImageId = 42,
            ImageUrl = "https://static1.cbrimages.com/wordpress/wp-content/uploads/2021/06/Hunter-x-Hunter-1.jpg",
            ProductId = 9 // Hunter x Hunter Box Set 1
          },
          new Image
          {
            ImageId = 43,
            ImageUrl = "https://staticg.sportskeeda.com/editor/2022/04/33e84-16505291054558-1920.jpg",
            ProductId = 9 // Hunter x Hunter Box Set 1
          },
          new Image
          {
            ImageId = 44,
            ImageUrl = "https://www.thenewshouse.com/wp-content/uploads/Untitled-design-4-1024x683.png",
            ProductId = 9 // Hunter x Hunter Box Set 1
          },
          new Image
          {
            ImageId = 45,
            ImageUrl = "https://staticg.sportskeeda.com/editor/2022/11/70a3e-16680920162796-1920.jpg",
            ProductId = 9 // Hunter x Hunter Box Set 1
          }

      );
    }
  }

}