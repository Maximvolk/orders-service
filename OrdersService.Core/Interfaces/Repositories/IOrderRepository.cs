using System.Threading.Tasks;
using System.Collections.Generic;
using OrdersService.Core.Entities;

namespace OrdersService.Core.Interfaces.Repositories
{
    public interface IOrderRepository
    {
        Task<IEnumerable<Order>> GetOrdersAsync();
        Task<bool> CheckOrderExistsAsync(Order order);
        Task AddOrderAsync(Order order);
    }
}