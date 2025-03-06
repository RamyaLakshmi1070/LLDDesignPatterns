using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    class TerminalExpression : IAbstractExpression
    {
        char a;
        public TerminalExpression(char a1)
        {
            a = a1;
        }
        public int Interpret(Context context)
        {
            return context.GetInteger(a);
        }
    }
}
