using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahmoudIbrahim_sun_wed_5pm_C_08
{
    internal class Duration
    {
        public double Hours { get; set; }
        public double Minutes { get; set; }
        public double Seconds { get; set; }

        // Constructor for hours, minutes, and seconds
        public Duration(int hours, int minutes, int seconds)
        {
            this.Hours = hours;
            this.Minutes = minutes;
            this.Seconds = seconds;
            Normalize();
        }

        // Constructor for total seconds
        public Duration(int totalSeconds)
        {
            this.Hours = totalSeconds / 3600;
            totalSeconds %= 3600;
            this.Minutes = totalSeconds / 60;
            this.Seconds = totalSeconds % 60;
            Normalize();
        }

        private void Normalize()
        {
            if (Seconds >= 60)
            {
                Minutes += Seconds / 60;
                Seconds %= 60;
            }
            if (Minutes >= 60)
            {
                Hours += Minutes / 60;
                Minutes %= 60;
            }
        }

        public override string ToString()
        {
            string result = string.Empty;
            if (Hours > 0)
                result += $"Hours: {Hours}, ";
            if (Minutes > 0 || Hours > 0)
                result += $"Minutes: {Minutes}, ";
            result += $"Seconds: {Seconds}";

            return result.TrimEnd(',', ' ');
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Duration))
                return false;

            Duration other = (Duration)obj;
            return this.Hours == other.Hours && this.Minutes == other.Minutes && this.Seconds == other.Seconds;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + Hours.GetHashCode();
                hash = hash * 23 + Minutes.GetHashCode();
                hash = hash * 23 + Seconds.GetHashCode();
                return hash;
            }
        }
        // Operator overloads
        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(int.Parse(d1.Hours.ToString()) + int.Parse(d2.Hours.ToString()), int.Parse((d1.Minutes + d2.Minutes).ToString()), int.Parse((d1.Seconds + d2.Seconds).ToString()));
        }

        public static Duration operator +(Duration d, int totalSeconds)
        {
            return new Duration((int.Parse(d.Hours.ToString()) * 3600 + int.Parse(d.Minutes.ToString()) * 60 + int.Parse(d.Seconds.ToString())) + totalSeconds);
        }

        public static Duration operator +(int totalSeconds, Duration d)
        {
            return d + totalSeconds;
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            int totalSeconds1 = int.Parse(d1.Hours.ToString()) * 3600 + int.Parse(d1.Minutes.ToString()) * 60 + int.Parse(d1.Seconds.ToString());
            int totalSeconds2 = int.Parse(d2.Hours.ToString()) * 3600 + int.Parse(d2.Minutes.ToString()) * 60 + int.Parse(d2.Seconds.ToString());
            return new Duration(totalSeconds1 - totalSeconds2);
        }

        public static Duration operator ++(Duration d)
        {
            return new Duration(int.Parse(d.Hours.ToString()), int.Parse((d.Minutes + 1).ToString()), int.Parse(d.Seconds.ToString()));
        }

        public static Duration operator --(Duration d)
        {
            return new Duration(int.Parse(d.Hours.ToString()), int.Parse((d.Minutes - 1).ToString()), int.Parse(d.Seconds.ToString()));
        }

        public static bool operator >(Duration d1, Duration d2)
        {
            int totalSeconds1 = int.Parse(d1.Hours.ToString()) * 3600 + int.Parse(d1.Minutes.ToString()) * 60 + int.Parse(d1.Seconds.ToString());
            int totalSeconds2 = int.Parse(d2.Hours.ToString()) * 3600 + int.Parse(d2.Minutes.ToString()) * 60 + int.Parse(d2.Seconds.ToString());
            return totalSeconds1 > totalSeconds2;
        }

        public static bool operator <(Duration d1, Duration d2)
        {
            return d2 > d1;
        }

        public static bool operator >=(Duration d1, Duration d2)
        {
            return !(d1 < d2);
        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            return !(d1 > d2);
        }

        public static implicit operator bool(Duration d)
        {
            return d.Hours != 0 || d.Minutes != 0 || d.Seconds != 0;
        }

        public static explicit operator DateTime(Duration d)
        {
            return new DateTime(1, 1, 1, int.Parse(d.Hours.ToString()), int.Parse(d.Minutes.ToString()), int.Parse(d.Seconds.ToString()));
        }
    }
}
