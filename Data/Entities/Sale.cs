using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    public class Sale
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public required int Id { get; set; }

        public required string Plate { get; set; }

        public required DateTime EntranceTime { get; set; }

        public DateTime? DepartureTime { get; set; } = null;

        public int? Price { get; set; } = null;

        public required int ParkingSpotId { get; set; }

        public required ParkingSpot ParkingSpot { get; set; }

        public required int UserId { get; set; }

        public required User User { get; set; }
    }
}
