using System.Collections.Generic;
using System.Linq;

namespace Orders.Services
{
    public interface IOrderService
    {
        IEnumerable<OrderEntity> GetOrders();
    }
}
