﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithBridgePattern
{
    class Fish : LivingThings
    {
        public Fish(BreatheProcessImplementor breatheProcessImplementor) : base(breatheProcessImplementor)
        {

        }
        public override void Breathe()
        {
            base.breatheProcessImplementor.BreatheProcess();
        }
    }
}
