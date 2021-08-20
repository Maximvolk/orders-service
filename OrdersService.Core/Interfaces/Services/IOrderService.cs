using System.Threading.Tasks;
using System.Collections.Generic;
using OrdersService.Common.Resources;

namespace OrdersService.Core.Interfaces.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderResource>> GetOrdersAsync();
        Task CreateOrderAsync(OrderResource orderResource);
    }
}