using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    class SingleRoom : IRoomElement
    {
        public int roomPrice = 0;
        public void accept(IVisitor visitor)
        {
            visitor.visit(this);
        }
    }
}
