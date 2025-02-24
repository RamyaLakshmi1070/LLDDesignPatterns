namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IArithmeticExpression number1 = new Expression(10);
            IArithmeticExpression number2 = new Expression(7);
            IArithmeticExpression number3 = new Expression(12);

            IArithmeticExpression arithmeticExpression = new ArithmeticExpression(number2, number3, Operator.Add);
            IArithmeticExpression arithmeticExpression1 = new ArithmeticExpression(number1, arithmeticExpression, Operator.Add);
            
            arithmeticExpression.Evaluate();
            arithmeticExpression1.Evaluate();

        }
    }
}
