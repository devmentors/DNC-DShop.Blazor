using System.Collections.Generic;
using DShop.Blazor.Areas.Customers.Models;

namespace DShop.Blazor.Areas.Orders.Models
{
    public class OrderDetails : Order
    {
        public Customer Customer { get; set; }
        public IEnumerable<OrderItem> Items { get; set; }
    }
}