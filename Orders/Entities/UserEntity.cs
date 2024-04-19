using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orders.Entities
{
    public class UserEntity
    {

        [Key]
        [Column("user_id")]
        public int UserId { get; set; }

        [Required]
        [StringLength(50)]
        [Column("username")]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        [Column("email")]
        public string Email { get; set; }

        [Required]
        [StringLength(255)]
        [Column("password")]
        public string Password { get; set; }

        [StringLength(10)]
        [Column("country_code")]
        public string CountryCode { get; set; }

        [StringLength(10)]
        [Column("department_code")]
        public string DepartmentCode { get; set; }

        [StringLength(10)]
        [Column("city_code")]
        public string CityCode { get; set; }

        [StringLength(20)]
        [Column("contact_number")]
        public string ContactNumber { get; set; }

        [StringLength(255)]
        [Column("address")]
        public string Address { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public UserEntity(int userId, string userName, string email, string password, string countryCode, string departmentCode, string cityCode, string contactNumber, string address, DateTime createdAt)
        {
            UserId = userId;
            UserName = userName;
            Email = email;
            Password = password;
            CountryCode = countryCode;
            DepartmentCode = departmentCode;
            CityCode = cityCode;
            ContactNumber = contactNumber;
            Address = address;
            CreatedAt = createdAt;
        }   
    }
}
