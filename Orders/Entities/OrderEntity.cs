using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class OrderEntity
{
    
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("order_id")]
    public int OrderId { get; set; }

    [Required]
    [Column("user_id")]
    public int UserId { get; set; }

    [Required]
    [Column("username")]
    public string UserName { get; set; }

    [Required]
    [Column("email")]
    public string Email { get; set; }

    [Required]
    [Column("contact_number")]
    public string ContactNumber { get; set; }

    [Required]
    [Column("country_code")]
    public string CountryCode { get; set; }

    [Required]
    [Column("department_code")]
    public string DepartmentCode { get; set; }

    [Required]
    [Column("city_code")]
    public string CityCode { get; set; }

    [Required]
    [Column("address")]
    public string Address { get; set; }

    [Required]
    [Column("subtotal_price")]
    public decimal SubtotalPrice { get; set; }

    [Required]
    [Column("total_taxes")]
    public decimal TotalTaxes { get; set; }

    [Required]
    [Column("total_price")]
    public decimal TotalPrice { get; set; }

    [Required]
    [Column("payment_id")]
    public int PaymentId { get; set; }

    [Required]
    [Column("tracking_id")]
    public int TrackingId { get; set; }

    [Required]
    [Column("order_modification")]
    public DateTime OrderModification { get; set; } = DateTime.Now;

}
