using System;

namespace StateDesignPattern
{
    internal class Inventory
    {
        private ItemSelf[] inventory;

        public Inventory(int size)
        {
            inventory = new ItemSelf[size];
            InitializeEmptyInventory();
        }

        private void InitializeEmptyInventory()
        {
            for (int i = 0; i < inventory.Length; i++)
            {
                inventory[i] = new ItemSelf();
                inventory[i].SetCode(101 + i);
                inventory[i].SetSoldOut(true);
            }
        }

        public ItemSelf[] GetInventory()
        {
            return inventory;
        }

        public void SetInventory(ItemSelf[] itemSelves)
        {
            inventory = itemSelves;
        }

        public void AddItems(Items items, int code)
        {
            foreach (ItemSelf itemSelf in inventory)
            {
                if (itemSelf.GetCode() == code)
                {
                    if (itemSelf.IsSoldOut())
                    {
                        itemSelf.SetSoldOut(false);
                        itemSelf.SetItems(items);
                        Console.WriteLine($"Item {items.GetType()} added successfully.");
                    }
                    else
                    {
                        Console.WriteLine($"Item {items.GetType()} is already available.");
                    }
                    return;
                }
            }
            throw new Exception($"Invalid code {code}. Item not found in inventory.");
        }

        public Items GetItems(int code)
        {
            foreach (ItemSelf itemSelf in inventory)
            {
                if (itemSelf.GetCode() == code)
                {
                    if (!itemSelf.IsSoldOut())
                    {
                        return itemSelf.Item;
                    }
                    else
                    {
                        throw new Exception($"Item with code {code} is sold out.");
                    }
                }
            }
            throw new Exception($"Item with code {code} not found.");
        }

        internal void UpdateSoldOutItems(int code)
        {
            foreach (ItemSelf itemSelf in inventory)
            {
                if (itemSelf.GetCode() == code)
                {
                    itemSelf.SetSoldOut(true);
                    itemSelf.SetItems(null);
                    Console.WriteLine($"Item with code {code} is now sold out.");
                    return;
                }
            }
            Console.WriteLine($"Item with code {code} not found.");
        }
    }
}
