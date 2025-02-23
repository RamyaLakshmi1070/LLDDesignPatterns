using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern;
     interface IState
    {
        void ClickOnInsertCashButton(VendingMachine vendingMachine);
        void ClickOnProductButton(VendingMachine vendingMachine);
        void InsertCoin(VendingMachine vendingMachine, Coins coin);
        void ChooseProduct(VendingMachine vendingMachine, int codeNumber);
        List<Coins> RefundMoney(VendingMachine vendingMachine);
        void UpdateInventory(VendingMachine vendingMachine, Items item, int codeNumber);
        List<Coins> GetChange(int amount);
        Items DispenseProduct(VendingMachine vendingMachine, int codeNumber);

}
