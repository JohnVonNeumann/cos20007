namespace Library
{
    public class Book
    {
        private string _name;
        private string _author;
        private string _isbn;
        private bool _onLoan;

        public Book(string name, string creator, string isbn)
        {
            _name = name;
            _author = creator;
            _isbn = isbn;
            _onLoan = false;
        }

        public string Name
        {
            get
            {
                return _name;
            }
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

        public bool OnLoan
        {
            get
            {
                return _onLoan;
            }

            set
            {
                _onLoan = value;
            }
        }

    }
}