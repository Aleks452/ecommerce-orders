using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Orders.dtos;
using Orders.Entities;
using Orders.Exceptions;
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

        [HttpPost]
        public async Task<IActionResult> GetOrders([FromBody] OrderDataDTO orderData)
        {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            var result =  await _orderService.GetOrdersAsync(orderData.UserId);
            return Ok(result);
        }

        [HttpPost("add-order")]
        public async Task<IActionResult> addOrder([FromBody] ShoppingCheckoutDTO shoppingCheckoutDTO) { 
            
            bool success = await _orderService.AddOrderAsync(shoppingCheckoutDTO);

            if (success)
            {
                return StatusCode(201, "Product created succesfully.");
            }
            else
            {
                throw new InternalErrorException();
            }

        }
    }
}
