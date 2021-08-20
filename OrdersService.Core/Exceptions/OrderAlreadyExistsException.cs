using System;

namespace OrdersService.Core.Exceptions
{
    public class OrderAlreadyExistsException : AbstractDomainException
    {
        public OrderAlreadyExistsException(string message) : base(message) {}
    }
}