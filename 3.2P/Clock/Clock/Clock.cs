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

        /// <summary>
        /// <c></c>
        /// property <code> Time </code>
        /// <remarks> Originally used a String.format but Rider complained about it.
        ///           Since found out that apparently in certain situations the interpolation
        ///           is managed at compile time so could have a perf boost
        /// </remarks>
        /// <returns> A string containing the current time of the clock</returns>
        /// </summary>
        public string Time
        {
            get
            {
                return $"{_hour.Ticks:00}:{_minute.Ticks:00}:{_second.Ticks:00}";
            } 
        }
    }
}