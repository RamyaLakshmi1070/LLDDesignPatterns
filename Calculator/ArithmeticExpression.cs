using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class ArithmeticExpression : IArithmeticExpression
    {
        IArithmeticExpression leftExpression;
        IArithmeticExpression rightExpression;
        Operator Operator;
        public ArithmeticExpression(IArithmeticExpression leftExpression,
        IArithmeticExpression rightExpression,
        Operator Operator)
        {
            this.leftExpression = leftExpression;
            this.rightExpression = rightExpression;
            this.Operator = Operator;
        }
        public int Evaluate()
        {
            int value = 0;
            switch(Operator)
            {
                case Operator.Add:
                    value= leftExpression.Evaluate() + rightExpression.Evaluate();
                    break;
                case Operator.Subtract:
                    value = leftExpression.Evaluate() - rightExpression.Evaluate();
                    break;
                case Operator.Multiply:
                    value = leftExpression.Evaluate() * rightExpression.Evaluate();
                    break;
                case Operator.Division:
                    value = leftExpression.Evaluate() / rightExpression.Evaluate();
                    break;

            }
            Console.WriteLine("Expression value"+value);
            return value;
           
        }
    }
}
