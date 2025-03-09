using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorSystem
{
    public class ElevatorCart
    {
        public int id;
        Display display;
        Status status;
        Door door;
        int currentfloor;
        public ElevatorCart()
        {
            currentfloor = 0;
            display=new Display(currentfloor);
            status = Status.Idle;
            door = new Door();
        }
        public void Move(int destinationFloor)
        {
            if(currentfloor<destinationFloor)
            {
                for(int i=currentfloor;i<=destinationFloor;i++)
                {
                    currentfloor = i;
                    display.ShowDisplay(currentfloor);
                }
            }
            else
            {
                for(int i=currentfloor;i>=destinationFloor;i--)
                {
                    currentfloor = i;
                    display.ShowDisplay(currentfloor);
                }
            }
        }
        public int GetCurrentFloor()
        {
            return currentfloor;
        }
    }
}
