namespace StateDesignPattern
{
    internal class ItemSelf
    {
        public Items Item { get; private set; }
        public int Code { get; private set; }
        public bool SoldOut { get; private set; }

        public ItemSelf()
        {
            Code = -1;  // Default invalid code
            SoldOut = true;
        }

        public void SetCode(int code)
        {
            Code = code;
        }

        public void SetItems(Items item)
        {
            Item = item;
        }

        public void SetSoldOut(bool sold)
        {
            SoldOut = sold;
        }

        internal int GetCode()
        {
            return Code;
        }

        internal bool IsSoldOut()
        {
            return SoldOut;
        }
    }
}
