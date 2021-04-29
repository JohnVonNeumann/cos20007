using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace Library
{
    public class Library
    {
        private List<Book> _books;
        private List<Game> _games;
        
        public Library(string name) {}
        
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