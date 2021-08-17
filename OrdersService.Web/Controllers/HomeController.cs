using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OrdersService.Web.Models;
using OrdersService.Core.Interfaces.Services;

namespace OrdersService.Web.Controllers
{
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
            var orders = await _service.GetOrdersAsync();
            return View(orders);
        }
    }
}
