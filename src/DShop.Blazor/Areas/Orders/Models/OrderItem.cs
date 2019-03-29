using System;

namespace DShop.Blazor.Areas.Orders.Models
{
    public class OrderItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}