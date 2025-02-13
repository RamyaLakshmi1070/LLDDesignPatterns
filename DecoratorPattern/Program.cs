namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasePizza pizza = new CheeseToppings(new MargheritaPizza());
            Console.WriteLine("Pizza Cost "+ pizza.PizzaCost());
        }
    }
}
