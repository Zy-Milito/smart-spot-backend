using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<ParkingSpot> ParkingSpots { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<ParkingFee> Fees { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ParkingFee halfAnHour = new ParkingFee()
            {
                Id = 1,
                Description = "Half an hour",
                Fee = 130
            };

            ParkingFee firstHour = new ParkingFee()
            {
                Id = 2,
                Description = "First hour",
                Fee = 130
            };

            ParkingFee additionalHours = new ParkingFee()
            {
                Id = 3,
                Description = "Additional hours",
                Fee = 80
            };

            modelBuilder.Entity<ParkingFee>().HasData(halfAnHour, firstHour, additionalHours);

            modelBuilder.Entity<ParkingSpot>().HasMany(p => p.Sales).WithOne(s => s.ParkingSpot).HasForeignKey(s => s.ParkingSpotId);
            modelBuilder.Entity<User>().HasMany(u => u.Sales).WithOne(u => u.User).HasForeignKey(s => s.UserId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
