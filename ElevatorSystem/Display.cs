using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorSystem
{
    class Display
    {
        int floor;
        public Display(int f)
        {
            floor = f;
        }

        public void ShowDisplay(int floor)
        {
            Console.WriteLine("Current Floor "+floor);
        }
    }
}
