using Orders.Entities;
using Orders.Exceptions;

namespace Orders.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly ApplicationDbContext _context;

        public PaymentService(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<PaymentsEntity> GetAllPayments()
        {
            try
            {
                return _context.Payments.OrderBy(p => p.PaymentType).ToList();
            }
            catch (Exception ex) {
                throw new InternalErrorException(ex.Message);
            }
        }
    }
}
