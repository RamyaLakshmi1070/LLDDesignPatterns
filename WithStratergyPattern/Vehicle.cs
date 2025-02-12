using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithStratergyPattern
{
    class Vehicle
    {
        public readonly IDriveStratergy _driveStratergy;

        public Vehicle(IDriveStratergy driveStratergy)
        {
            _driveStratergy = driveStratergy;
        }
        public void Drive()
        {
            _driveStratergy.Drive();
        }
    }
}
