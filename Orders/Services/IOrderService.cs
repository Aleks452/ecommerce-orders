using Orders.dtos;
using System.Linq;

namespace Orders.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<UserOrdersConsolidateDTO>> GetOrdersAsync(int userId);

        Task<bool> AddOrderAsync(ShoppingCheckoutDTO shoppingCheckoutDTO);
    }
}
