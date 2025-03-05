using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    interface IRoomElement
    {
        void accept(IVisitor visitor);
    }
}
