namespace InterpreterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            context.Put('a', 1);
            context.Put('b', 2);
            context.Put('c', 3);
            context.Put('d', 4);
            TerminalExpression terminalExpression = new TerminalExpression('a');
            TerminalExpression terminalExpression1 = new TerminalExpression('b');
            TerminalExpression terminalExpression2 = new TerminalExpression('c');
            TerminalExpression terminalExpression3 = new TerminalExpression('d');
            var e1 = new NonTerminalExpression(terminalExpression, terminalExpression1);
            var e2 = new NonTerminalExpression(terminalExpression2, terminalExpression3);
            NonTerminalExpression nonTerminalExpression = new NonTerminalExpression(e1,e2);
            Console.WriteLine(nonTerminalExpression.Interpret(context));
           
            // (a*b)*(c*d)
        }
    }
}
