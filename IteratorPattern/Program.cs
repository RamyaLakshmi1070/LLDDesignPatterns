namespace IteratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("HarryPotter", 100);
            Book book2 = new Book("DSA", 450);

            List<Book> lst = new List<Book>();
            lst.Add(book1);
            lst.Add(book2);

            Library library = new Library(lst);
            var obj = library.CreateIterator();
            while(obj.HasNext())
            {
                Book book =(Book) obj.Next();
                Console.WriteLine(book.GetName());
            }
        }
    }
}
