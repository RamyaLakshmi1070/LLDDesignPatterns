using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutBridgePattern
{
    class Fish : LivingThings
    {
        public override void BreatheProcess()
        {
            Console.WriteLine("Breathe through Gills");
            Console.WriteLine("Inhale oxygen from Water");
            Console.WriteLine("Exhale carbon Dioxide");
        }
    
    }
}
