using System;
using System.Collections.Generic;
using System.Text;

namespace TimeRep
{
    class Time
    {
        int hours;
        int minutes;
        int seconds;
        public int Hours
        {
            get => hours;
            private set
            {
                if (value < 0 || value > 24)
                    throw new ArgumentOutOfRangeException("hours","Can't fit so much hours");
                hours = value;
            }

        }
        public int Minutes
        {
            get => minutes;
            private set
            {
                if (value < 0 || value > 60)
                    throw new ArgumentOutOfRangeException("minutes","Can't fit so much minutes");
                minutes = value;
            }
        }
        public int Seconds
        {
            get => seconds; private set
            {
                if (value < 0 || value > 60)
                    throw new ArgumentOutOfRangeException("seconds","Can't fit so much seconds");
                seconds = value;
            }
        }
        public void ChangeTime(int hours, int minutes, int seconds)
        {
            if(Seconds+seconds>=60)
            {
                this.Seconds = Seconds + seconds - 60;
                this.Minutes++;
            }
            else
            {
                this.Seconds += seconds;
            }
            if (Minutes + minutes >= 60)
            {
                this.Minutes = Minutes + minutes - 60;
                this.Hours++;
            }
            else
            {
                this.Minutes += minutes;
            }
            if (Hours + hours >= 24)
            {
                this.Hours = Hours + hours - 24;
            }
            else
            {
                this.Hours += hours;
            }
        }
        public override string ToString()
        {
            return string.Format($"Time is {Hours:D2}.{ Minutes:D2}.{ Seconds:D2}");
        }
    }
}
