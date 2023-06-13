using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeShop.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }

        [Required]
        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product? Product { get; set; }

        [Required]
        public string? UserId { get; set; }

        public ApplicationUser? User { get; set; }

        [Range(1, 5)]
        public int Rating { get; set; }

        [StringLength(500)]
        public string? Comment { get; set; }
    }
}