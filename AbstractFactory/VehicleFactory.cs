﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class VehicleFactory
    {
        public abstract Vehicle CreateFactory(String name);
    }
}
