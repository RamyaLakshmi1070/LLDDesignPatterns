using System;
using System.Collections.Generic;

namespace StateDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize vending machine
            VendingMachine vendingMachine = new VendingMachine();

            // Fill inventory with some items
            vendingMachine.GetInventory().AddItems(new Items(ItemType.Coffee, 25), 101);
            vendingMachine.GetInventory().AddItems(new Items(ItemType.Coke, 35), 102);
            vendingMachine.GetInventory().AddItems(new Items(ItemType.Miranda, 45), 103);

            // Display initial inventory
            Console.WriteLine("Current Inventory:");
            foreach (var item in vendingMachine.GetInventory().GetInventory())
            {
                if (!item.IsSoldOut())
                {
                    Console.WriteLine($"Code: {item.GetCode()}, Item: {item.Item.ItemType}, Price: {item.Item.Price} cents");
                }
            }
            Console.WriteLine();

            // Start vending machine process
            try
            {
                Console.WriteLine("Clicking Insert Cash Button...");
                vendingMachine.SetVendingState(new HasMoneyState());

                Console.WriteLine("Inserting coins...");
                vendingMachine.GetCoins().Add(Coins.Quarter);
                vendingMachine.GetCoins().Add(Coins.Nickel);
                Console.WriteLine($"Total inserted: {vendingMachine.GetCoins().Sum(c => (int)c)} cents");

                Console.WriteLine("Selecting a product...");
                vendingMachine.SetVendingState(new SelectionState());
                vendingMachine.GetVendingState().ChooseProduct(vendingMachine, 101);

                Console.WriteLine("Dispensing product...");
                vendingMachine.SetVendingState(new DispenseState(vendingMachine, 101));
                vendingMachine.GetVendingState().DispenseProduct(vendingMachine, 101);

                // Display inventory after transaction
                Console.WriteLine("\nInventory after transaction:");
                foreach (var item in vendingMachine.GetInventory().GetInventory())
                {
                    string status = item.IsSoldOut() ? "Sold Out" : "Available";
                    Console.WriteLine($"Code: {item.GetCode()}, Item: {(item.Item != null ? item.Item.ItemType.ToString() : "None")}, Status: {status}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
