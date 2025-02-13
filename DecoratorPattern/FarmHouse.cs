using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class FarmHouse : BasePizza
    {
        public override int PizzaCost()
        {
            return 100;
        }
    }
}
