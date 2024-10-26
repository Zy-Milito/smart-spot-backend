using Data.Entities;

namespace Data.Repository
{
    public class ParkingSpotRepository : IParkingSpotRepository
    {
        private readonly ApplicationContext _context;
        public ParkingSpotRepository(ApplicationContext context)
        {
            _context = context;
        }

        public List<ParkingSpot> GetAll()
        {
            return _context.ParkingSpots.ToList();
        }

        public void AddParkingSpot(ParkingSpot parkingSpot)
        {
            _context.ParkingSpots.Add(parkingSpot);
        }

        public void MakeUnavailable(int parkingSpotId)
        {
            _context.ParkingSpots.Single(p => p.Id == parkingSpotId).Availability = false;
        }

        public void MakeAvailable(int parkingSpotId)
        {
            _context.ParkingSpots.Single(p => p.Id == parkingSpotId).Availability = true;
        }

        public void DeleteParkingSpot(int parkingSpotId)
        {
            _context.ParkingSpots.Single(p => p.Id == parkingSpotId).Status = Models.StatusEnum.Deleted;
        }
    }
}
