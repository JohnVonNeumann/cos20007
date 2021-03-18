using System;

namespace CounterObject
{
    public class MainClass
    {
        public static void Main()
        {
            Console.WriteLine("Hello World!");
            Counter[] myCounters = new Counter[3];

            myCounters[0] = new Counter("Counter 1");
            myCounters[1] = new Counter("Counter 2");
            myCounters[2] = myCounters[0];

            for (int i = 0; i < 5; i++)
            {
                myCounters[0].Increment();
            }

            for (int i = 0; i < 10; i++)
            {
                myCounters[1].Increment();
            }

            PrintCounters(myCounters);

            myCounters[2].Reset();

            PrintCounters(myCounters);

        }

        private static void PrintCounters(Counter[] counters)
        {
            foreach (var c in counters)
            {
                Console.WriteLine("{0} is {1}", c.Name, c.Ticks.ToString());
                
            }
        }
    }

    public class Counter
    {
        private int _count;
        private string _name;

        public Counter(string name)
        {
            _name = name;
            _count = 0;
        }

        public void Increment()
        {
            _count++;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public void Reset()
        {
            _count = 0;
        }

        public int Ticks
        {
            get
            {
                return _count;
            }
        }

    }
}