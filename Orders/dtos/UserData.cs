using System.ComponentModel.DataAnnotations;

namespace Orders.dtos
{
    public class UserData
    {
        [Range(1, int.MaxValue, ErrorMessage = "UserId must be greater than 0")]
        public int userId {  get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "UserId must be greater than 0")]
        public int statusId { get; set; }
    }
}
