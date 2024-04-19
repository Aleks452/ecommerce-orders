using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orders.Entities
{
    public class PaymentsEntity
    {
        
        [Key]
        [Column("payment_id")]
        public int PaymentId {  get; set; }

        [Column("payment_type")]
        public string PaymentType { get; set; }

        public PaymentsEntity(int paymentId, string paymentType)
        {
            this.PaymentId = paymentId;
            this.PaymentType = paymentType;
        }

    }
}
