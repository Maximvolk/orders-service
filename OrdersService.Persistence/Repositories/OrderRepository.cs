using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using OrdersService.Core.Interfaces.Repositories;
using OrdersService.Core.Entities;
using OrdersService.Persistence;

namespace OrdersService.Persistence.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrdersServiceContext _context;

        public OrderRepository(OrdersServiceContext context) => _context = context;

        public async Task<IEnumerable<Order>> GetOrdersAsync()
        => await _context.Orders.ToListAsync();

        public async Task<bool> CheckOrderExistsAsync(Order order)
        {
            return await _context.Orders.AnyAsync(o =>
                o.SourceCity == order.SourceCity &&
                o.SourceAddress == order.SourceAddress &&
                o.DestinationCity == order.DestinationCity &&
                o.DestinationAddress == order.DestinationAddress &&
                o.Weight == order.Weight &&
                o.PickUpDate == order.PickUpDate);
        }

        public async Task AddOrderAsync(Order order)
        {
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
        }
    }
}