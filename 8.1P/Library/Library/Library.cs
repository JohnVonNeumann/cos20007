using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

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
        
        public void AddBook(Book b) {}
        
        public void AddGame(Game g) {}

        public bool HasBook(string name)
        {
            throw new NotImplementedException();
        }
        
        public bool HasGame(string name)
        {
            throw new NotImplementedException();
        }
        
    }
}