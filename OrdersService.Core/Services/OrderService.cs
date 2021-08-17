using System.Threading.Tasks;
using System.Collections.Generic;
using OrdersService.Common.Resources;
using OrdersService.Common.Responses;
using OrdersService.Core.Interfaces.Repositories;
using OrdersService.Core.Entities;
using OrdersService.Core.Interfaces.Services;
using AutoMapper;

namespace OrdersService.Core.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repository;
        private readonly IMapper _mapper;

        public OrderService(IOrderRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<OrderResource>> GetOrdersAsync()
        {
            var orders = await _repository.GetOrdersAsync();
            return _mapper.Map<IEnumerable<Order>, IEnumerable<OrderResource>>(orders);
        }

        public async Task<OrderResponse> CreateOrderAsync(OrderResource order)
        {
            return new OrderResponse {};
        }
    }
}