namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory vehicleFactory = new LuxuryCarFactory();
            Vehicle vehicle=vehicleFactory.CreateFactory("Car1");
            vehicle.ShowDetails();

        }
    }
}
