namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderFacade orderFacade = new OrderFacade();
            orderFacade.MakeOrder();
        }
    }
}
