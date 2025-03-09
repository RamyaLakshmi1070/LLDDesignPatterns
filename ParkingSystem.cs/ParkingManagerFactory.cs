namespace ParkingSystem.cs
{
    internal class ParkingManagerFactory
    {
        public ParkingSpotManager CreateManager(VehicleType vehicle)
        {
            if (vehicle is VehicleType.CAR || vehicle is VehicleType.TRUCK)
                return new FourWheelerParkingManager();
            else
                return new TwoWheelerParkingManager();
        }
    }
}