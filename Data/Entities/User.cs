using Data.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public required int Id { get; set; }

        public required string Username { get; set; }

        public required string Email { get; set; }

        public required string Password { get; set; }

        public required RoleEnum Role { get; set; } = RoleEnum.Standard;

        public required StatusEnum Status { get; set; } = StatusEnum.Active;

        public ICollection<Sale> Sales { get; set; } = [];
    }
}
