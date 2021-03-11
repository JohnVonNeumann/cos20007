using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {

        Message myMessage;
        myMessage = new Message("Hello World - from Message Object");
        myMessage.Print();
        
        Console.ReadLine();

        }
    }
}
