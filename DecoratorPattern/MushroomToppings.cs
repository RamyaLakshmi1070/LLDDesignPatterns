using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class MushroomToppings:Toppings
    {
        private readonly BasePizza _basepizza;

        public MushroomToppings(BasePizza basePizza)
        {
            this._basepizza = basePizza;
        }
        public override int PizzaCost()
        {
            return _basepizza.PizzaCost() + 10;
        }
    }
}
