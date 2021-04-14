using System;

namespace Clock
{
    class Program
    {
        static void Main()
        {
            Clock clock = new Clock();

            for (int i = 0; i < 82245; i++)
            {
                clock.Tick();
            }

            Console.WriteLine("Should output: 22:50:45");
            Console.WriteLine(clock.Time);
        }
    }
}