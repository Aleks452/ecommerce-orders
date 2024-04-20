using Orders.dtos;
using Orders.Entities;

namespace Orders.Services
{
    public interface IShoppingCarService
    {
        Task<IEnumerable<ShoppingCarTotalDTO>> GetCustomDataAsync(int userId, int statusId);

    }
}
