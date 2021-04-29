using Library.Abstract;

namespace Library
{
    public class Book : LibraryResource 
    {
        private string _author;
        private string _isbn;

        public Book(string name, string creator, string isbn) : base(name)
        {
            _author = creator;
            _isbn = isbn;
        }

        public string Creator
        {
            get
            {
                return _author;
            }
        }

        public string ISBN
        {
            get
            {
                return _isbn;
            }
        }

    }
}