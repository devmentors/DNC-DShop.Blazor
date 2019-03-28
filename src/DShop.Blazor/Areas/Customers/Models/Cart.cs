using System;
using System.Collections.Generic;

namespace DShop.Blazor.Areas.Customers.Models
{
    public class Cart
    {
        public Guid Id { get; set; }
        public IEnumerable<CartItem> Items { get; set; }
        public decimal TotalPrice { get; set; }
    }
}