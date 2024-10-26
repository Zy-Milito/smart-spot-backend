using Data.Entities;

namespace Data.Repository
{
    public interface IParkingSpotRepository
    {
        List<ParkingSpot> GetAll();
        void AddParkingSpot(ParkingSpot parkingSpot);
        void MakeUnavailable(int parkingSpotId);
        void MakeAvailable(int parkingSpotId);
        void DeleteParkingSpot(int parkingSpotId);
    }
}
