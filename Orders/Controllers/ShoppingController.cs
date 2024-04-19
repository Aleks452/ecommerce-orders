using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Orders.Services;
using Orders.dtos; // Asegúrate de tener el espacio de nombres correcto para tu DTO

namespace Orders.Controllers
{
    [ApiController]
    [Route("api/shopping")]
    public class ShoppingController : ControllerBase
    {
        private readonly IShoppingCarService _shoppingCarService;

        public ShoppingController(IShoppingCarService shoppingCarService)
        {
            _shoppingCarService = shoppingCarService;
        }

        [HttpPost("customdata")]
        public async Task<IActionResult> GetCustomData([FromBody] UserData userdata)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _shoppingCarService.GetCustomDataAsync(userdata.userId, userdata.statusId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
