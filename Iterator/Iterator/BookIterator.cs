namespace Iterator.Example1
{
    using System.Collections.Generic;

    public class BookIterator : IIterator<Book>
    {
        private List<Book> books;
        private int position = 0;

        public BookIterator(List<Book> books)
        {
            this.books = books;
        }

        public bool HasNext()
        {
            return this.position < this.books.Count;
        }

        public Book Next()
        {
            Book book = this.books[this.position];
            this.position++;

            return book;
        }
    }
}
