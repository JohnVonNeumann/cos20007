using Library.Abstract;

namespace Library
{
    public class Game : LibraryResource
    {
        private string _developer;
        private string _contentRating;

        public Game(string name, string creator, string rating) : base(name)
        {
            _developer = creator;
            _contentRating = rating;
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
    }
}