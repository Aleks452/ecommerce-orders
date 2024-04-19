using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Orders.Entities;
using Orders.Services;

namespace Orders.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public IEnumerable<OrderEntity> GetOrders()
        {
            return _orderService.GetOrders();
        }
    }
}
