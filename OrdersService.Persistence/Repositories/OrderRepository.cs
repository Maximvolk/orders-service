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
    }
}