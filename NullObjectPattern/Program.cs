namespace NullObjectPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
           VehicleFactory vehicleFactory=new VehicleFactory();
            var vehicleobject = vehicleFactory.GetVehicle("Bike");
            Console.WriteLine(vehicleobject.GetTankCapacity());
            Console.WriteLine(vehicleobject.GetSeatCapacity());

            var vehicleobjects = vehicleFactory.GetVehicle("Car");
            Console.WriteLine(vehicleobjects.GetTankCapacity());
            Console.WriteLine(vehicleobjects.GetSeatCapacity());
        }
    }
}
