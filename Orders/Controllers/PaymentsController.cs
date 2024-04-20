using Microsoft.AspNetCore.Mvc;
using Orders.Entities;
using Orders.Services;
using System.Collections;

namespace Orders.Controllers
{
    [ApiController]
    [Route("/api/payment")]
    public class PaymentsController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public PaymentsController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }


        [HttpGet]
        public IEnumerable<PaymentsEntity> GetAllPayments() { 
        
            return _paymentService.GetAllPayments();    
        }
    }
}
