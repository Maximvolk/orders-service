using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using OrdersService.Web.Models;
using OrdersService.Core.Interfaces.Services;
using OrdersService.Common.Resources;
using OrdersService.Core.Exceptions;
using OrdersService.Web.Filters;

namespace OrdersService.Web.Controllers
{
    [TypeFilter(typeof(CustomExceptionFilter))]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IOrderService _service;

        public HomeController(ILogger<HomeController> logger, IOrderService service)
        {
            _logger = logger;
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            // For redirect from ExceptionHandler
            if (TempData["Error"] != null)
                ViewData["Error"] = TempData["Error"].ToString();

            IEnumerable<OrderResource> orders = new OrderResource[] {};

            // Workaround for situation where error occurres in orders retrieval
            // Otherwise this method will be called many times until it proceeds without exception
            try
            {
                orders = await _service.GetOrdersAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex.InnerException?.Message);
            }

            return View(orders);
        }

        [HttpPost("CreateOrder")]
        public async Task<IActionResult> CreateOrderAsync(string sourceCity, string sourceAddress,
            string destinationCity, string destinationAddress, decimal weight, string pickUpDate)
        {
            var order = new OrderResource
                {
                    SourceCity = sourceCity,
                    SourceAddress = sourceAddress,
                    DestinationCity = destinationCity,
                    DestinationAddress = destinationAddress,
                    Weight = weight,
                    PickUpDate = pickUpDate
                };

            await _service.CreateOrderAsync(order);
            return RedirectToAction("Index");
        }
    }
}
