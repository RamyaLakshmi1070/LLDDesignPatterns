﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Triangle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Triangle");
        }
    }
}
