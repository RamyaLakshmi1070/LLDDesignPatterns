using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Expression : IArithmeticExpression
    {
        int value;
        public Expression(int value)
        {
            this.value = value;
        }
        public int Evaluate()
        {
            Console.WriteLine("Value "+value);
            return value;
        }
    }
}
