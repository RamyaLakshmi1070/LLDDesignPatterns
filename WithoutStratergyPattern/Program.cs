namespace WithoutStratergyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle sport = new SportVehicle();
            sport.drive();

            Vehicle passenger = new PassengerVehicle();
            passenger.drive();

            Vehicle offroad = new OffRoadVehicle();
            offroad.drive();
        }
    }
}
