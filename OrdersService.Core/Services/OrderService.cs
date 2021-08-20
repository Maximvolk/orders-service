using System;
using System.Globalization;
using System.Threading.Tasks;
using System.Collections.Generic;
using OrdersService.Common.Resources;
using OrdersService.Core.Interfaces.Repositories;
using OrdersService.Core.Entities;
using OrdersService.Core.Interfaces.Services;
using OrdersService.Core.Exceptions;
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

        public async Task CreateOrderAsync(OrderResource orderResource)
        {
            ValidateUpcomingOrder(orderResource);
            var order = _mapper.Map<OrderResource, Order>(orderResource);

            if (await _repository.CheckOrderExistsAsync(order))
                throw new OrderAlreadyExistsException("Order already exists");

            await _repository.AddOrderAsync(order);
        }

        private void ValidateUpcomingOrder(OrderResource orderResource)
        {
            if (String.IsNullOrEmpty(orderResource.SourceCity))
                throw new ValidationException("Source City must be filled");

            if (String.IsNullOrEmpty(orderResource.SourceAddress))
                throw new ValidationException("Source Address must be filled");

            if (String.IsNullOrEmpty(orderResource.DestinationCity))
                throw new ValidationException("Destination City must be filled");

            if (String.IsNullOrEmpty(orderResource.DestinationAddress))
                throw new ValidationException("Destination Address must be filled");

            if (String.IsNullOrEmpty(orderResource.PickUpDate))
                throw new ValidationException("Pick-up Date must be filled"); 

            if (orderResource.Weight <= 0)
                throw new ValidationException("Weight must be positive number");

            DateTime pickUpDate;

            if (!DateTime.TryParseExact(orderResource.PickUpDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out pickUpDate))
                throw new ValidationException("Invalid pick-up date. Date must be specified in the following format: dd/MM/yyyy");
        }
    }
}