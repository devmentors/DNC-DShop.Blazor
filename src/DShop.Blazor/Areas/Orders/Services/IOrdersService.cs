using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using DShop.Blazor.Areas.Orders.Models;

namespace DShop.Blazor.Areas.Orders.Services
{
    public interface IOrdersService
    {
        Task<IEnumerable<Order>> GetAsync();
        Task CreateAsync();
        Task CompleteAsync(Order order);
        Task CancelAsync(Order order);
    }
}