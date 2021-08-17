using System.Threading.Tasks;
using System.Collections.Generic;
using OrdersService.Common.Resources;
using OrdersService.Common.Responses;

namespace OrdersService.Core.Interfaces.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderResource>> GetOrdersAsync();
        Task<OrderResponse> CreateOrderAsync(OrderResource order);
    }
}