using System.Collections.Generic;

namespace IteratorsAndComparators
{
    public class Program
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002,
            "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);

            Library libraryOne = new Library();
            Library libraryTwo = new Library(bookOne, bookTwo, bookThree);

            foreach (var library in libraryTwo)
            {
                Console.WriteLine($"{string.Join(", ", library.Author)} - {library.Title} - {library.Year}");
            }

            IEnumerator<Book> enumerator = Something();

            while (enumerator.MoveNext())
            {
                Console.WriteLine($"{string.Join(", ", enumerator.Current.Author)} - {enumerator.Current.Title} - {enumerator.Current.Year}");
            }
        }

        static IEnumerator<Book> Something() 
        {
            Console.WriteLine("First");
            yield return new Book("The Shining", 2001, "Stephen King");

            Console.WriteLine("Second");
            yield return new Book("The Shining", 2001, "Stephen King");

            Console.WriteLine("Third");
            yield return new Book("The Shining", 2001, "Stephen King");
        }
    }
}