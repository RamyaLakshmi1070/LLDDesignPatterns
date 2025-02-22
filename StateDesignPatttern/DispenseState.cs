using System;
using System.Collections.Generic;

namespace StateDesignPattern
{
    internal class DispenseState : IState
    {
        private readonly VendingMachine vendingMachine;
        private readonly int codeNumber;

        public DispenseState(VendingMachine vendingMachine, int codeNumber)
        {
            this.vendingMachine = vendingMachine;
            this.codeNumber = codeNumber;
        }

        public void ChooseProduct(VendingMachine vendingMachine, int codeNumber)
        {
            Console.WriteLine("Dispensing in progress. Cannot choose a product now.");
        }

        public void ClickOnInsertCashButton(VendingMachine vendingMachine)
        {
            Console.WriteLine("Cannot insert cash while dispensing.");
        }

        public void ClickOnProductButton(VendingMachine vendingMachine)
        {
            Console.WriteLine("Product already selected, dispensing...");
        }

        public Items DispenseProduct(VendingMachine vendingMachine, int codeNumber)
        {
            Items item = vendingMachine.GetInventory().GetItems(codeNumber);

            if (item == null)
            {
                Console.WriteLine("Item not available. Refunding money.");
                vendingMachine.SetVendingState(new IdleState());
                return null;
            }

            vendingMachine.GetInventory().UpdateSoldOutItems(codeNumber);
            Console.WriteLine($"Dispensing {item.GetType()}...");

            // Clear inserted coins after dispensing
            vendingMachine.GetCoins().Clear();

            // Move to Idle state
            vendingMachine.SetVendingState(new IdleState());

            return item;
        }
        public List<Coins> GetChange(int amount)
        {
            List<Coins> change = new List<Coins>();
            int[] coinValues = { 25, 10, 5, 1 }; // Quarter, Dime, Nickel, Penny

            foreach (int value in coinValues)
            {
                while (amount >= value)
                {
                    change.Add((Coins)value);
                    amount -= value;
                }
            }

            return change;
        }

        public void InsertCoin(VendingMachine vendingMachine, Coins coins)
        {
            Console.WriteLine("Cannot insert coins while dispensing.");
        }

        public List<Coins> RefundMoney(VendingMachine vendingMachine)
        {
            Console.WriteLine("Cannot refund money while dispensing.");
            return new List<Coins>();
        }

        public void UpdateInventory(VendingMachine vendingMachine, Items items, int codeNumber)
        {
            Console.WriteLine("Cannot update inventory while dispensing.");
        }
    }
}
