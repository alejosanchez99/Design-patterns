
using Iterator.Example1;

Library library = new Library();

IIterator<Book> iterator = library.CreateIterator();

while (iterator.HasNext())
{
    Book book = iterator.Next();
    Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
}