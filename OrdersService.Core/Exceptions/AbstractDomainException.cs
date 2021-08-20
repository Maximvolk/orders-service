using System;

namespace OrdersService.Core.Exceptions
{
    public abstract class AbstractDomainException : Exception
    {
        protected AbstractDomainException(string message) : base(message) {}
    }
}