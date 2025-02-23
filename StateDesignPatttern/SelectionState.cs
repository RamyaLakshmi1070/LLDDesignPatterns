using System;
using System.Collections.Generic;

namespace StateDesignPattern
{
    internal class SelectionState : IState
    {
        public void ChooseProduct(VendingMachine vendingMachine, int codeNumber)
        {
            Items item = vendingMachine.GetInventory().GetItems(codeNumber);
            int paidByUser = 0;

            foreach (Coins coin in vendingMachine.GetCoins())
            {
                paidByUser += (int)coin;
            }

            if (paidByUser < item.Price)
            {
                Console.WriteLine($"Insufficient funds: Inserted {paidByUser}, required {item.Price}.");
                List<Coins> refund = RefundMoney(vendingMachine);
                throw new InvalidOperationException($"Insufficient amount. Refunding: {string.Join(", ", refund)}.");
            }

            int change = paidByUser - item.Price;
            if (change > 0)
            {
                Console.WriteLine($"Returning change: {string.Join(", ", GetChange(change))}");
            }

            Console.WriteLine($"Product {item.GetType()} selected. Moving to Dispense State.");
            vendingMachine.SetVendingState(new DispenseState(vendingMachine, codeNumber));
        }

        public void ClickOnInsertCashButton(VendingMachine vendingMachine)
        {
            Console.WriteLine("Cash has already been inserted.");
        }

        public void ClickOnProductButton(VendingMachine vendingMachine)
        {
            Console.WriteLine("Product selection is active.");
        }

        public Items DispenseProduct(VendingMachine vendingMachine, int codeNumber)
        {
            throw new InvalidOperationException("Cannot dispense before finalizing selection.");
        }

        public void InsertCoin(VendingMachine vendingMachine, Coins coin)
        {
            Console.WriteLine($"Coin inserted: {(int)coin} cents.");
            vendingMachine.GetCoins().Add(coin);
        }

        public List<Coins> RefundMoney(VendingMachine vendingMachine)
        {
            Console.WriteLine("Refunding money...");
            List<Coins> refundedCoins = new List<Coins>(vendingMachine.GetCoins());
            vendingMachine.GetCoins().Clear();
            vendingMachine.SetVendingState(new IdleState());
            return refundedCoins;
        }

        public void UpdateInventory(VendingMachine vendingMachine, Items item, int codeNumber)
        {
            vendingMachine.GetInventory().AddItems(item, codeNumber);
            Console.WriteLine("Inventory updated.");
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
    }
}
