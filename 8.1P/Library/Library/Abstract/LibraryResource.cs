namespace Library.Abstract
{
    public abstract class LibraryResource
    {
        private string _name;
        private bool _onLoan;

        public LibraryResource(string name)
        {
            _name = name;
            _onLoan = false;
        }

        public string Name
        {
            get
            {
                return _name;
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

        public abstract string Creator
        {
            get;
        }
    }
}