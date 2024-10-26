using Data.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    public class ParkingSpot
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public required int Id { get; set; }

        public required string Number { get; set; }

        public required bool Availability { get; set; } = true;

        public required StatusEnum Status { get; set; } = StatusEnum.Active;

        public ICollection<Sale> Sales { get; set; } = [];
    }
}
