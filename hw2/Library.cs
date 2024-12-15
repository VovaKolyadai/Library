using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    internal class Library
    {
        private List<Book> _bookCatalog;
        public Library()
        {
            _bookCatalog = new List<Book>()
            {
                new Book("TestBook", "Ctor", "C#")
            };
        }
        public Library(List<Book> books)
        {
            if (books != null)
                _bookCatalog = books;
            else throw new Exception("Can't create empty library");
        }
        public void DonateBook(Book book)
        {
            if (book == null 
                || string.IsNullOrEmpty(book.Name) 
                || string.IsNullOrEmpty(book.Author)
                || string.IsNullOrEmpty(book.Publisher)) 
                    throw new Exception("Can't donate a void");
            if (_bookCatalog == null) _bookCatalog = new List<Book>();
            _bookCatalog.Add(book);
        }
        public Book? BorrowBook(int bookIndex)
        {
            if(_bookCatalog == null || bookIndex < 0)
                return null;
            if(_bookCatalog.Count > bookIndex)
            {
                var bookToBorrow = _bookCatalog[bookIndex];
                _bookCatalog.RemoveAt(bookIndex);
                return bookToBorrow;
            }
            return null;
        }
        public int FindBook(string bookName, string authorName, string publisher)
        {
            if (_bookCatalog == null)
                return -1;
            if (string.IsNullOrEmpty(bookName)
                || string.IsNullOrEmpty(authorName)
                || string.IsNullOrEmpty(publisher)) 
                    throw new ArgumentNullException("cant search for null");
            return _bookCatalog.FindIndex(x => x.Name.Equals(bookName) || x.Author.Equals(authorName) || x.Publisher.Equals(publisher));
        }
        public int FindBookByName(string bookName)
        {
            if (_bookCatalog == null)
                return -1;
            if (string.IsNullOrEmpty(bookName))
                throw new ArgumentNullException("cant search for null");
            return _bookCatalog.FindIndex(x => x.Name.Contains(bookName));
        }
        public int FindBookByAuthor(string author)
        {
            if (_bookCatalog == null)
                return -1;
            if (string.IsNullOrEmpty(author))
                throw new ArgumentNullException("cant search for null");
            return _bookCatalog.FindIndex(x => x.Name.Contains(author));
        }
        public int FindBookByPublisher(string publisher)
        {
            if (_bookCatalog == null)
                return -1;
            if (string.IsNullOrEmpty(publisher))
                throw new ArgumentNullException("cant search for null");
            return _bookCatalog.FindIndex(x => x.Name.Contains(publisher));
        }
        public void ChangePublisher(int bookIndex, string newPublisher)
        {
            if(string.IsNullOrEmpty(newPublisher)) throw new ArgumentNullException("Publisher field shouldn't be null or empty");
            _bookCatalog[bookIndex].Publisher = newPublisher;
        }
    }
}
