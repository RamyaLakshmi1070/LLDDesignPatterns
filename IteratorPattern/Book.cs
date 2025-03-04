namespace IteratorPattern
{
    internal class Book
    {
        String bookName;
        int bookPrice;
        public Book(String bookName,int bookPrice)
        {
            this.bookName = bookName;
            this.bookPrice = bookPrice;
        }

        public String GetName()
        {
            return bookName;
        }
        public int GetPrice()
        {
            return bookPrice;
        }
    }
}