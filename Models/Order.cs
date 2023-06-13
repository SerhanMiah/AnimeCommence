using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AnimeShop.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public string? UserId { get; set; }
        
        public ApplicationUser? User { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        public List<OrderItem>? OrderItems { get; set; }

        public decimal TotalPrice => OrderItems?.Sum(item => item.UnitPrice * item.Quantity) ?? 0M;

        public string? ShippingAddress { get; set; }
        
        public string? BillingAddress { get; set; }
        
        public string? PaymentMethod { get; set; }
        
        public OrderStatus Status { get; set; }
    }

    public enum OrderStatus
    {
        Placed,
        Processing,
        Shipped,
        Delivered,
        Cancelled
    }
}