using PrototypePattern.WithoutPrototypePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.WithPrototypePattern
{
    interface Prototype
    {
        public Student1 Clone();
    }
}
