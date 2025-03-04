using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Library : IAggregate
    {
        List<Book> list;
        public Library(List<Book> iterators)
        {
            this.list = iterators;
        }
        public IIterator CreateIterator()
        {
            return new BookListIterator(list);
        }
    }
}
