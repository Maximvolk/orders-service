namespace OrdersService.Core.Exceptions
{
    public class ValidationException : AbstractDomainException
    {
        public ValidationException(string message) : base(message) {}
    }
}