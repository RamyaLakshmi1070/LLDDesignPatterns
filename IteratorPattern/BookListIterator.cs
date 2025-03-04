using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class BookListIterator : IIterator
    {
        List<Book> list;
        int index = 0;
        public BookListIterator(List<Book> books)
        {
            list = books;
        }
        public bool HasNext()
        {
            return (index<list.Count);
        }

        public object Next()
        {
            return list[index++];
        }
    }
}
