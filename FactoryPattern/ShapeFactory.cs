using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class ShapeFactory
    {
        private readonly IShape shape;

        public IShape? GetShape(String name)
        {
            switch(name)
            {
                case "Circle":
                    return new Circle();
                case "Triangle": 
                    return new Triangle();
                case "Rectangle": 
                    return new Rectangle();
                default: 
                    return null;
            }

        }
    }
}
