namespace ParkingSystem.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Adding Two Spot
            Vehicle vehicle = new Vehicle(Convert.ToInt16(Guid.NewGuid()), VehicleType.BIKE);
            ParkingSpot parkingSpot = new TwoWheelerParkingSpot(Convert.ToInt16(Guid.NewGuid()),vehicle);
            List<ParkingSpot> parkingSpots = new List<ParkingSpot>();
            parkingSpots.Add(parkingSpot);
            ParkingSpotManager parkingSpotManager = new TwoWheelerParkingManager(parkingSpots);

            Vehicle vehicle1 = new Vehicle(Convert.ToInt16(Guid.NewGuid()), VehicleType.CAR);
            ParkingSpot parkingSpot1 = new FourWheelerParkingSpot(Convert.ToInt16(Guid.NewGuid()), vehicle1);
            List<ParkingSpot> parkingSpots2 = new List<ParkingSpot>();
            parkingSpots2.Add(parkingSpot);
            ParkingSpotManager parkingSpotManager2 = new FourWheelerParkingManager(parkingSpots);



        }
    }
}
