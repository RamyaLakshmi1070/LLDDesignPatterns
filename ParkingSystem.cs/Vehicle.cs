namespace ParkingSystem.cs
{
    internal class Vehicle
    {
        int vehicleNo;
        VehicleType vehicleType;
        public Vehicle(int vno,VehicleType vehicleType)
        {
            this.vehicleNo = vno;
            this.vehicleType = vehicleType;
        }
    }
}