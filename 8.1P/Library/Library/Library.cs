using System.Collections.Generic;

namespace Library
{
    public class Library
    {
        private string _name;
        private List<Book> _books;
        private List<Game> _games;

        public Library(string name)
        {
            _name = name;
            _books = new List<Book>();
            _games = new List<Game>();
        }

        public void AddBook(Book b)
        {
            _books.Add(b);
        }

        public void AddGame(Game g)
        {
            _games.Add(g);
        }

        public bool HasBook(string name)
        {
            foreach (Book book in _books)
            {
                if (book.Name == name)
                {
                    return true;
                }
            }

            return false;
        }

        public bool HasGame(string name)
        {
            foreach (Game game in _games)
            {
                if (game.Name == name)
                {
                    return true;
                }
            }

            return false;
        }
    }
}