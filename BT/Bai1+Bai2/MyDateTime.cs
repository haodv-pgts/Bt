using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_Bai2
{
    public class MyDateTime
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Hour { get; set; }
        public int Day { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }
        public long Timestamp { get; set; }


        public const int Monday = 1;
        public const int Tuesday = 2;
        public const int Wednesday = 3;
        public const int Thursday = 4;
        public const int Friday = 5;
        public const int Saturday = 6;
        public const int Sunday = 7;
        private DateTime parsedDate;

        public MyDateTime()
        {
           SetDatetime(DateTime.Now);
        }

        public MyDateTime(long timestamp)
        {
            DateTime dateTime = DateTimeOffset.FromUnixTimeSeconds(timestamp).DateTime;
            SetDatetime(dateTime);
        }
        public MyDateTime(int year, int month, int day, int hour, int minute, int second, long Timestamp)
        {
            Year = year;
            Month = month;
            Day = day;
            Hour = hour;
            Minute = minute;
            Second = second;
            Timestamp = new DateTime(year, month, day, hour, minute, second).Ticks;
        }
        public MyDateTime(int year, int month, int day, int hour, int minute, int second)
        {
            Year = year;
            Month = month;
            Day = day;
            Hour = hour;
            Minute = minute;
            Second = second;
        }
        public MyDateTime(DateTime dateTime)
        {
            Year = dateTime.Year;
            Month = dateTime.Month;
            Day = dateTime.Day;
            Hour = dateTime.Hour;
            Minute = dateTime.Minute;
            Second = dateTime.Second;
            Timestamp = dateTime.Ticks;
        }
        private void SetDatetime(DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        private void SetDatetime(MyDateTime dateTime)
        {
            Year = dateTime.Year;
            Month = dateTime.Month;
            Hour = dateTime.Hour;
            Day = dateTime.Day;
            Minute = dateTime.Minute;
            Second = dateTime.Second;
            Timestamp = dateTime.Timestamp;
        }
        
        public static MyDateTime createFromString(string dateString)
        
        {
            DateTime parsedDate;
            string[] formats = {
                   "yyyy-MM-dd HH:mm:ss"
            };
            if (DateTime.TryParseExact(dateString,
                                    formats,
                                    System.Globalization.CultureInfo.InvariantCulture,
                                    System.Globalization.DateTimeStyles.None,
                                    out parsedDate))
            {
                return new MyDateTime(parsedDate);
            } else {
                throw new ArgumentException("Invalid input");
            }
        }
       


        public MyDateTime AddMinutes(int n)
        {
            DateTime currentDateTime = new DateTime(Year, Month, Day, Hour, Minute, Second);
            DateTime newDatetime = currentDateTime.AddMinutes(n);
            return new MyDateTime(newDatetime);
        }
        public int DiffInMinutes(MyDateTime orther)
        {
            DateTime currentDateTime = new DateTime(Year, Month, Day, Hour, Minute, Second);
            DateTime otherDateTime = new DateTime(orther.Year, orther.Month, orther.Day, orther.Hour, orther.Minute, orther.Second);
            TimeSpan result = otherDateTime - currentDateTime;
            return (int)Math.Abs(result.TotalMinutes);
        }

        public Boolean IsSameMonth (MyDateTime ortherTimeDate)
        {
            DateTime currentDateTime = new DateTime(Year, Month, Day, Hour, Minute, Second);
            DateTime orther = new DateTime(ortherTimeDate.Year, ortherTimeDate.Month, ortherTimeDate.Day, ortherTimeDate.Hour, ortherTimeDate.Minute, ortherTimeDate.Second); 
            var month = orther.Month;
            var checkMonth = month == currentDateTime.Month ? true : false;
            if (checkMonth)
            {
                Console.WriteLine("Input month is the same as the current month.");
                return true;
            }
            else {
                Console.WriteLine("Input month is not the same as the current month.");
                return false;
            }
        }
   
        public Boolean IsThursday(MyDateTime orther)
        {

            DateTime orthers = new DateTime(orther.Year, orther.Month, orther.Day, orther.Hour, orther.Minute, orther.Second);
            bool isEqual = orthers.DayOfWeek == DayOfWeek.Thursday;
            var checkDay = isEqual ? true : false;
            if (checkDay) {
                Console.WriteLine("Hom nay la Thursday");
                return true;
            }
            else
            {
                Console.WriteLine("Hom nay khong phai la Thursday");
                return false;
            }

        }
        public override string ToString()
        {
            return $"{Year:D4}-{Month:D2}-{Day:D2} {Hour:D2}:{Minute:D2}:{Second:D2}";
        }

       
    }
}
