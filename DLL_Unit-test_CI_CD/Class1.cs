using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeIntervalLibrary
{
    public class TimeInterval
    {
        private TimeSpan interval;

        
        public TimeInterval(int hours, int minutes, int seconds)
        {
            if (hours < 0 || minutes < 0 || seconds < 0)
                throw new ArgumentException("Часы, минуты и секунды не могут быть отрицательными.");

            interval = new TimeSpan(hours, minutes, seconds);
        }

        
        public void Add(TimeInterval other)
        {
            if (other == null)
                throw new ArgumentNullException(nameof(other), "Другой временной интервал не может быть null.");

            interval += other.interval;
        }

        
        public void Subtract(TimeInterval other)
        {
            if (other == null)
                throw new ArgumentNullException(nameof(other), "Другой временной интервал не может быть null.");

            interval -= other.interval;
        }

        
        public override string ToString()
        {
            return interval.ToString();
        }

       
        public double TotalSeconds()
        {
            return interval.TotalSeconds;
        }

        
        public double TotalMinutes()
        {
            return interval.TotalMinutes;
        }

        
        public double TotalHours()
        {
            return interval.TotalHours;
        }
    }
}
