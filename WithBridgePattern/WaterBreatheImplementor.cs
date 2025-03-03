using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithBridgePattern
{
    class WaterBreatheImplementor : BreatheProcessImplementor
    {
        public void BreatheProcess()
        {
            Console.WriteLine("Breathe through Ghills");
            Console.WriteLine("Inhale oxygen  from Water");
            Console.WriteLine("Exhale carbon Dioxide");
        }
    }
}
