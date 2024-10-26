using Data.Entities;

namespace Services
{
    public interface IParkingSpotService
    {
        List<ParkingSpot> GetAll();
        void UpdateAvailability(int parkingSpotId, bool currentValue);
        void Delete(int parkingSpotId);
    }
}
