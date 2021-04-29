namespace Library
{
    public class Game
    {
        private string _name;
        private string _developer;
        private string _contentRating;
        private bool _onLoan;

        public Game(string name, string creator, string rating)
        {
            _name = name;
            _developer = creator;
            _contentRating = rating;
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
                return _developer;
            }
        }

        public string ContentRating
        {
            get
            {
                return _contentRating;
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