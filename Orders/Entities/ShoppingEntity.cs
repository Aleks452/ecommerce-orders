using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Orders.Entities
{
    public class ShoppingEntity
    {

        [Key]
        [Column("shopping_id")]
        public int ShoppingId { get; set; }

        [Required]
        [Column("user_id")]
        public int UserId { get; set; }

        [Required]
        [Column("product_id")]
        public int ProductId { get; set; }

        [Required]
        [Column("product_quantity")]
        public int ProductQuantity { get; set; }

        [Required]
        [Column("product_price", TypeName = "decimal(10, 2)")]
        public decimal ProductPrice { get; set; }

        [Required]
        [Column("product_taxes", TypeName = "decimal(10, 2)")]
        public decimal ProductTaxes { get; set; }

        [Required]
        [Column("status_id")]
        public int StatusId { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public ShoppingEntity(int shoppingId, int userId, int productId, int productQuantity, decimal productPrice, decimal productTaxes, int statusId, DateTime createdAt)
        {
            ShoppingId = shoppingId;
            UserId = userId;
            ProductId = productId;
            ProductQuantity = productQuantity;
            ProductPrice = productPrice;
            ProductTaxes = productTaxes;
            StatusId = statusId;
            CreatedAt = createdAt;
        }
    }

}
