using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem.cs
{
     abstract class ParkingSpot
    {
        int id;
        bool isEmpty;
        Vehicle vehicle;
        int price;
        public ParkingSpot()
        {
            id = Convert.ToInt32(Guid.NewGuid());
        }

        public void ParkVehicle(Vehicle v)
        {
            if (isEmpty)
            {
                vehicle = v;
                isEmpty = false;
                Console.WriteLine("Vehicle has been parked");
            }
            else
            {
                Console.WriteLine("Unable to Park Vehicle");
            }
        }

        public void UnParkVehicle()
        {
            if(!isEmpty)
            {
                isEmpty = true;
                vehicle = null;
                Console.WriteLine("Unparked");
            }
            else
            {
                Console.WriteLine("Not able to unpark");
            }
        }
        public abstract int GetPrice();
    }
}
