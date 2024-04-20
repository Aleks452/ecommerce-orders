using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orders.Entities
{
    public class TrackingEntity
    {
        
        [Key]
        [Column("tracking_id")]
        public int TrackingId { get; set; }

        [Required]
        [StringLength(50)]
        [Column("tracking_type")]
        public string TrackingType { get; set; }

        public TrackingEntity(int trackingId, string trackingType)
        {
            TrackingId = trackingId;
            TrackingType = trackingType;
        }
    }
}
