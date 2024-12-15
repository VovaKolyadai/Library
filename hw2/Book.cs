using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    internal class Book
    {
        private string _name;
        private string _author;
        public string Name
        {
            get
            {
                return _name;
            }
            private set
            {
                _name = value;
            }
        }
        public string Author
        {
            get
            {
                return _author;
            }
            private set
            {
                _author = value;
            }
        }
        public string Publisher { get; set; }
        public Book(string name, string author, string publisher)
        {
            _name = name;
            _author = author;
            Publisher = publisher;
        }

    }
}
