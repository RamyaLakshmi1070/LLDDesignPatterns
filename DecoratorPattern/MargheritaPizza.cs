using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class MargheritaPizza : BasePizza
    {
        public override int PizzaCost()
        {
            return 80;
        }
    }
}
