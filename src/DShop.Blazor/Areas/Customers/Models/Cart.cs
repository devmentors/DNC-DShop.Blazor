using System;
using System.Collections.Generic;
using System.Linq;

namespace DShop.Blazor.Areas.Customers.Models
{
    public class Cart
    {
        public Guid Id { get; set; }
        public List<CartItem> Items { get; set; }
        public decimal TotalPrice => Items.Sum(i => i.TotalPrice);
    }
}