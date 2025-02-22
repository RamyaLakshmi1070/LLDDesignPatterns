namespace StateDesignPattern
{
    internal class HasMoneyState : IState
    {
        public void ChooseProduct(VendingMachine vendingMachine, int codeNumber)
        {
            Console.WriteLine($"Product with code {codeNumber} selected. Moving to Selection State.");
            vendingMachine.SetVendingState(new SelectionState());
        }

        public void ClickOnInsertCashButton(VendingMachine vendingMachine)
        {
            Console.WriteLine("Cash is already inserted.");
        }

        public void ClickOnProductButton(VendingMachine vendingMachine)
        {
            vendingMachine.SetVendingState(new SelectionState());
            Console.WriteLine("Product selection enabled.");
        }

        public Items DispenseProduct(VendingMachine vendingMachine, int codeNumber)
        {
            throw new InvalidOperationException("Cannot dispense product before selection.");
        }

        public void InsertCoin(VendingMachine vendingMachine, Coins coins)
        {
            vendingMachine.GetCoins().Add(coins);
            Console.WriteLine($"Coin inserted: {coins}. Current balance: {vendingMachine.GetCoins().Sum(c => (int)c)} cents.");
        }

        public List<Coins> RefundMoney(VendingMachine vendingMachine)
        {
            Console.WriteLine("Refunding money. Returning to Idle State.");
            List<Coins> refundedCoins = new List<Coins>(vendingMachine.GetCoins());
            vendingMachine.GetCoins().Clear();
            vendingMachine.SetVendingState(new IdleState());
            return refundedCoins;
        }

        public List<Coins> GetChange(int amount)
        {
            List<Coins> change = new List<Coins>();

            int[] coinValues = { 25, 10, 5, 1 };
            foreach (int value in coinValues)
            {
                while (amount >= value)
                {
                    change.Add((Coins)value);
                    amount -= value;
                }
            }

            Console.WriteLine($"Returning change: {string.Join(", ", change)}");
            return change;
        }

        public void UpdateInventory(VendingMachine vendingMachine, Items items, int codeNumber)
        {
            vendingMachine.GetInventory().AddItems(items, codeNumber);
            Console.WriteLine("Inventory updated successfully.");
        }
    }
}
