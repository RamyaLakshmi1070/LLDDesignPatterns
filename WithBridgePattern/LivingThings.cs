using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithBridgePattern
{
     abstract class LivingThings
    {
        protected BreatheProcessImplementor breatheProcessImplementor;
        public LivingThings(BreatheProcessImplementor breatheProcessImplementor)
        {
            this.breatheProcessImplementor = breatheProcessImplementor;
        }
        public abstract void Breathe();
    }
}
