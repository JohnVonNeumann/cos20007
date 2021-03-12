using System;

namespace HelloWorld
{
    internal static class MainClass
    {
        public static void Main(string[] args)
        {

        Message[] messages = new Message[4];
        messages[0] = new Message("Welcome back oh great educator");
        messages[1] = new Message("What a lovely name");
        messages[2] = new Message("Great name");
        messages[3] = new Message("That is a silly name");
        
        Message myMessage = new Message("Hello World - from Message Object");
        myMessage.Print();
        
        Console.WriteLine("Enter name:");
        string line = Console.ReadLine();

        if (!string.IsNullOrEmpty(line))
        {
            switch (line)
            {
                case "Josh":
                    messages[0].Print();
                    break;
                case "Jack":
                    messages[1].Print();
                    break;
                case "Mitch":
                    messages[2].Print();
                    break;
                default:
                    messages[3].Print();
                    break;
            }             
        }
        else
        {
            Console.WriteLine("If you don't provide a name, I can't work properly!");
        }

        }
    }
}
