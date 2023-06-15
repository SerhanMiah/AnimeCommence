using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AnimeShop.Models
{
    public enum Category
    {
        Manga,
        DVD,
        Merchandise,
        Apparel
    }

    public enum Genre
    {
        Shonen,
        Shojo,
        Seinen,
        Josei,
        Kodomomuke,
        Isekai
    }

    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

        [Range(0, 99999.99)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public Category Category { get; set; }

        public Genre Genre { get; set; }

        public DateTime ReleaseDate { get; set; }

        [StringLength(50)]
        public string? Publisher { get; set; }

        [Range(0, 5)]
        public float Rating { get; set; }

        public List<Image>? Images { get; set; }

        [StringLength(50)]
        public string? Artist { get; set; }

        [StringLength(50)]
        public string? Author { get; set; }

        public int Pages { get; set; }

        public string? Language { get; set; }

        [StringLength(100)]
        public string? ISBN { get; set; }

        public bool InStock { get; set; }

        public string? Size { get; set; }

        [StringLength(50)]
        public string? Color { get; set; }

        public int Quantity { get; set; }

        public string? Manufacturer { get; set; }

        public string? Platform { get; set; }
        
        public int Duration { get; set; }

        [StringLength(100)]
        public string? Studio { get; set; }
        
        public string? Region { get; set; }

        public string? Subtitles { get; set; }
    }

    public class Image
    {
        [Key]
        public int ImageId { get; set; }

        [Required]
        [StringLength(200)]
        public string? ImageUrl { get; set; }

        [Required]
        public int ProductId { get; set; }

        public Product? Product { get; set; }
    }
}
