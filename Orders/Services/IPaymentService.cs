using Orders.Entities;

namespace Orders.Services
{
    public interface IPaymentService
    {
        IEnumerable<PaymentsEntity> GetAllPayments();
    }
}
