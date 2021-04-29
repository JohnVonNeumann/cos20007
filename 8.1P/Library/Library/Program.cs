using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library("Victorian State Library");

            Book darkAlliance = new Book("Dark Alliance", "Gary Webb", "12345");
            Book marketsSolved = new Book("The Man Who Solved the Markets", "Jim Simons", "98765");
            darkAlliance.OnLoan = true;

            Game fable = new Game("Fable", "Lionhead Studios", "M");
            Game grandTheftAuto = new Game("Grand Theft Auto 4", "Rockstar Games", "R");
            grandTheftAuto.OnLoan = true;

            library.AddResource(darkAlliance);
            library.AddResource(marketsSolved);
            library.AddResource(fable);
            library.AddResource(grandTheftAuto);

            Console.WriteLine("Is Dark Alliance Available for Loan? " + library.HasResource("Dark Alliance"));
            Console.WriteLine("Is Fable Available for Loan? " + library.HasResource("Fable"));
        }
    }
}