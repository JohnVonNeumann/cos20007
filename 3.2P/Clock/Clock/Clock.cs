namespace Clock
{
    public class Clock
    {
        private Counter _hour;
        private Counter _minute;
        private Counter _second;

        public Clock()
        {
            _hour = new Counter("hour");
            _minute = new Counter("minute");
            _second = new Counter("second");
        }

        public void Tick()
        {
            
        }

        public void Reset()
        {
            
        }

        public string Time
        {
            get
            {
                return "Time";
            } 
        }
    }
}