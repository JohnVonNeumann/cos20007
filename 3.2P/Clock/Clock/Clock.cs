using System;

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
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public string Time
        {
            get
            {
                return $"{_hour.Ticks:00}:{_minute.Ticks:00}:{_second.Ticks:00}";
            } 
        }
    }
}