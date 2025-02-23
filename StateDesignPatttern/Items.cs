namespace StateDesignPattern
{
    public class Items
    {
        public ItemType ItemType { get; }
        public int Price { get; }

        public Items(ItemType itemType, int price)
        {
            ItemType = itemType;
            Price = price;
        }

        public override string ToString()
        {
            return $"{ItemType} - Price: {Price}";
        }
    }
}
