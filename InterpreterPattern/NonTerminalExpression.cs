using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    class NonTerminalExpression : IAbstractExpression
    {
        IAbstractExpression abstractExpression1; 
        IAbstractExpression abstractExpression2;
        public NonTerminalExpression(IAbstractExpression abstractExpression1,IAbstractExpression abstractExpression2)
        {
            this.abstractExpression1 = abstractExpression1;
            this.abstractExpression2 = abstractExpression2;
        }
        public int Interpret(Context context)
        {
            return abstractExpression1.Interpret(context) * abstractExpression2.Interpret(context);
        }
    }
}
