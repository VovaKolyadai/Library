using System.Xml;

namespace hw2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("","",""); //config ne pashet :(((. ya znau chto nuzhno pisat cherez var :)
            var testLib = new List<Book>();
            
            for (int i = 0; i < 15; i++)
            {
                book = new Book($"Name{i}",$"Author{i}",$"Publisher{i}");
                testLib.Add(book);
            }
            
            for (int i = 0; i < testLib.Count; i++)
            {
                Console.WriteLine($"{testLib[i].Name} {testLib[i].Author} {testLib[i].Publisher}");
            }
            Console.WriteLine();
            Console.WriteLine();
            var library = new Library(testLib);
            library.DonateBook(book);
            Console.WriteLine();
            var borrowedBook = library.BorrowBook(library.FindBook("Name1", "null", "null"));
            if (borrowedBook != null)
            {
                Console.WriteLine(borrowedBook.Name);
                Console.WriteLine(borrowedBook.Author);
                Console.WriteLine(borrowedBook.Publisher);
            }
            library.DonateBook(new Book("", "", ""));
            Console.WriteLine();
            library.ChangePublisher(library.FindBook("Name1", "null", "null"), "SHABALA");

            for (int i = 0; i < testLib.Count; i++)
            {
                Console.WriteLine($"{testLib[i].Name} {testLib[i].Author} {testLib[i].Publisher}");
            }
        }
    }
}
