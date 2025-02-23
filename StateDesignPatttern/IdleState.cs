using System;
using System.Collections.Generic;

namespace StateDesignPattern
{
    class IdleState : IState
    {
        public void ChooseProduct(VendingMachine vendingMachine, int codeNumber)
        {
            throw new InvalidOperationException("Cannot choose product without inserting cash.");
        }

        public void ClickOnInsertCashButton(VendingMachine vendingMachine)
        {
            Console.WriteLine("Cash insertion enabled. Please insert coins.");
            vendingMachine.SetVendingState(new HasMoneyState());
        }

        public void ClickOnProductButton(VendingMachine vendingMachine)
        {
            throw new InvalidOperationException("Cannot select product before inserting cash.");
        }

        public Items DispenseProduct(VendingMachine vendingMachine, int codeNumber)
        {
            throw new InvalidOperationException("Cannot dispense product in Idle state.");
        }

        public void InsertCoin(VendingMachine vendingMachine, Coins coins)
        {
            throw new InvalidOperationException("Insert Cash Button must be clicked before inserting a coin.");
        }

        public List<Coins> RefundMoney(VendingMachine vendingMachine)
        {
            throw new InvalidOperationException("No money to refund in Idle state.");
        }

        public void UpdateInventory(VendingMachine vendingMachine, Items item, int codeNumber)
        {
             vendingMachine.GetInventory().AddItems(item, codeNumber);
              Console.WriteLine("Inventory updated successfully.");
        }

        public List<Coins> GetChange(int amount)
        {
            throw new InvalidOperationException("No money to refund in Idle state.");
        }
    }
}
