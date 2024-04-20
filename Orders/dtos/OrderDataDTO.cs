using System.ComponentModel.DataAnnotations;

namespace Orders.dtos
{
    public class OrderDataDTO
    {
        [Range(1, int.MaxValue, ErrorMessage = "UserId must be greater than 0")]
        public int UserId { get; set; }
    }
}
