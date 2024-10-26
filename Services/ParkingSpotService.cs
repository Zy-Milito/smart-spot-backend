using Data.Entities;
using Data.Repository;

namespace Services
{
    public class ParkingSpotService : IParkingSpotService
    {
        private readonly IParkingSpotRepository _parkingSpotRepository;
        public ParkingSpotService(IParkingSpotRepository parkingSpotRepository)
        {
            _parkingSpotRepository = parkingSpotRepository;
        }

        public List<ParkingSpot> GetAll()
        {
            return _parkingSpotRepository.GetAll();
        }

        public void UpdateAvailability(int parkingSpotId, bool currentValue)
        {
            if (currentValue)
            {
                _parkingSpotRepository.MakeUnavailable(parkingSpotId);
            }
            else
            {
                _parkingSpotRepository.MakeAvailable(parkingSpotId);
            }
        }

        public void Delete(int parkingSpotId)
        {
            _parkingSpotRepository.DeleteParkingSpot(parkingSpotId);
        }
    }
}
