﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    interface IVisitor
    {
       void visit(SingleRoom singleRoom);
       void visit(DoubleRoom doubleRoom);
        void visit(DeluxeRoom deluxeRoom);
    }
}
