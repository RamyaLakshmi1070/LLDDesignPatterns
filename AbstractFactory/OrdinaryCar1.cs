﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class OrdinaryCar1 : Vehicle
    {
        public override void ShowDetails() => Console.WriteLine("Ordinary car1");
       
    }
}
