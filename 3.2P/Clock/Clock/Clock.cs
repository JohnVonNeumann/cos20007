using System;
using System.Data;

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
        
        /// <summary>
        /// method <code> Tick </code>
        /// Increments the 3 Counter objects that make up a Clock (Hour:Minute:Second).
        /// <remarks> I hate the implementation of the nested if statement, I want to make it cleaner. </remarks>
        /// </summary>
        /// <exception cref="InvalidExpressionException"></exception>
        public void Tick()
        {
            if (_second.Ticks == 59)
            {
                _second.Reset();
                if (_minute.Ticks == 59)
                {
                    _minute.Reset();
                    if (_hour.Ticks == 23)
                    {
                        throw new InvalidExpressionException("Program can only handle 24 hours.");
                    }
                    else
                    {
                        _hour.Increment();
                    }
                }
                else
                {
                    _minute.Increment();
                }
            }
            else
            {
                _second.Increment();
            }
        }

        public void Reset()
        {
            _hour.Reset();
            _minute.Reset();
            _second.Reset();
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