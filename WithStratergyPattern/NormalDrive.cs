using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithStratergyPattern
{
    class NormalDrive : IDriveStratergy
    {
        public void Drive()
        {
            Console.WriteLine("Normal Drive Capability");
        }
    }
}
