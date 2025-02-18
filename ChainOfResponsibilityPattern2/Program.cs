namespace ChainOfResponsibilityPattern2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VendingMachineHandler vendingMachineHandler = new CokeHandler(new SpriteHandler(new ColdCoffeeHandler(null)));
            vendingMachineHandler.Items(VendingMachineHandler.coldCoffee);
            vendingMachineHandler.Items(VendingMachineHandler.sprite);
            vendingMachineHandler.Items(VendingMachineHandler.coke);
        }
    }
}
