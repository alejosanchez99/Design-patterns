namespace Iterator.Example1
{
    using System.Collections.Generic;

    public class Library : ICollection<Book>
    {
        private readonly List<Book> books;

        public Library()
        {
            this.books = new List<Book>
            {
                new Book("1984", "George Orwell"),
                new Book("To kill a Mockingbird", "Harper Lee"),
                new Book("Moby-Dick", " Herman Melville")
            };
        }

        public IIterator<Book> CreateIterator()
        {
            return new BookIterator(this.books);
        }
    }
}
