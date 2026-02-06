using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WheelShare_dotNet.Models
{
    [Table("Rides")]
    public class Ride
    {

        [Key]
        public int RideId { get; set; }

        [Required]
        public int CustomerId { get; set; }

        public int? DriverId { get; set; }

        public double SourceLat { get; set; }
        public double SourceLng { get; set; }
        
        [MaxLength(500)]
        public string SourceAddress { get; set; }

        public double DestinationLat { get; set; }
        public double DestinationLng { get; set; }
        
        [MaxLength(500)]
        public string DestinationAddress { get; set; }

        public double DistanceKm { get; set; }
        public decimal Fare { get; set; }

        public decimal? FinalFare { get; set; }

        [Required, MaxLength(20)]
        public string RideStatus { get; set; }
        // Requested | Accepted | Started | Completed | Cancelled

        public DateTime RequestedAt { get; set; } = DateTime.UtcNow;
        public DateTime? AcceptedAt { get; set; }
        public DateTime? CompletedAt { get; set; }

        [ForeignKey("CustomerId")]
        public User Customer { get; set; }

        [ForeignKey("DriverId")]
        public Driver Driver { get; set; }
    }
}
