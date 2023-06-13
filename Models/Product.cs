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
        public decimal Price { get; set; }

        public Category Category { get; set; }

        public Genre Genre { get; set; }

        public DateTime ReleaseDate { get; set; }

        [StringLength(50)]
        public string? Publisher { get; set; }

        [Range(0, 5)]
        public float Rating { get; set; }

        public List<Image>? Images { get; set; }
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