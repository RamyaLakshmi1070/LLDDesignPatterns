using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithStratergyPattern
{
    class SpecialDrive: IDriveStratergy
    {
        public void Drive()
        {
            Console.WriteLine("Special Drive Capability");
        }
    }
}
