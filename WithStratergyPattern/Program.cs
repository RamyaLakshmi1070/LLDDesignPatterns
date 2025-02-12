namespace WithStratergyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle sport = new SportVehicle();
            sport.Drive();

            Vehicle passenger = new PassengerVehicle();
            passenger.Drive();

            Vehicle offroad = new OffRoadVehicle();
            offroad.Drive();
        }
    }
}
