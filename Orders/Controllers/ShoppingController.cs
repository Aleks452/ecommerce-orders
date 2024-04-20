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

        [HttpPost("checkout")]
        public async Task<IActionResult> GetCustomData([FromBody] UserDataDTO userdata)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _shoppingCarService.GetCustomDataAsync(userdata.userId, userdata.statusId);
            return Ok(result);
            
        }
    }
}
