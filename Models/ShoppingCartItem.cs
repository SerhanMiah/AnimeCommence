using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using AnimeShop.Models;

namespace AnimeShop.Models
{
    public class ShoppingCartItem
    {
    [Key]
    public int ShoppingCartItemId { get; set; }

    [Required]
    public string? UserId { get; set; }

    public ApplicationUser? User { get; set; }

    [Required]
    public int ProductId { get; set; }

    [ForeignKey(nameof(ProductId))]
    public Product? Product { get; set; }

    [Range(1, 100)]
    public int Quantity { get; set; }
    }
}