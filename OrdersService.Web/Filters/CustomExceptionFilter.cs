using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Logging;
using OrdersService.Core.Exceptions;

namespace OrdersService.Web.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        private readonly ITempDataDictionaryFactory _tempDataDictionaryFactory;
        private readonly ILogger _logger;

        public CustomExceptionFilter(ITempDataDictionaryFactory tempDataDictionaryFactory,
            ILogger<CustomExceptionFilter> logger)
        {
            _tempDataDictionaryFactory = tempDataDictionaryFactory;
            _logger = logger;
        }

        public void OnException(ExceptionContext filterContext)
        {
            filterContext.ExceptionHandled = true;
            _logger.LogError(filterContext.Exception.Message, filterContext.Exception.InnerException?.Message);

            var tempData = _tempDataDictionaryFactory.GetTempData(filterContext.HttpContext);
            tempData["Error"] = filterContext.Exception switch
            {
                AbstractDomainException => filterContext.Exception.Message,
                _ => "Unexpected error occurred"
            };

            filterContext.Result = new RedirectToRouteResult("default",
                new { controller = "Home", action = "Index" });
        }
    }
}