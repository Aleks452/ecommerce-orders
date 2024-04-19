using Orders.Entities;

namespace Orders.Services
{
    public class OrderService : IOrderService
    {
        private readonly ApplicationDbContext _dbContext;

        public OrderService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<OrderEntity> GetOrders()
        {
            return _dbContext.Orders.ToList();
        }
    }
}
