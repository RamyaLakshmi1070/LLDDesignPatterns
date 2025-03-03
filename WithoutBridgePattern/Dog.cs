using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutBridgePattern
{
    class Dog : LivingThings
    {
        public override void BreatheProcess()
        {
            Console.WriteLine("Breathe through Nose");
            Console.WriteLine("Inhale oxygen  from Air");
            Console.WriteLine("Exhale carbon Dioxide");
        }
    }
}
