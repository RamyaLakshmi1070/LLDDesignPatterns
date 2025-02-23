using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    class VendingMachine
    {
        private IState state;
        private readonly Inventory inventory;
        private readonly List<Coins> list;

        public VendingMachine()
        {
            state = new IdleState();
            inventory = new Inventory(10);
            list = new List<Coins>();
        }
        public void SetVendingState(IState newState)
        {
            state = newState;
        }
        public Inventory GetInventory()
        {
            return inventory;
        }
        public List<Coins> GetCoins()
        {
            return list;
        }

        internal IState GetVendingState()
        {
            return state;
        }
    }
}
