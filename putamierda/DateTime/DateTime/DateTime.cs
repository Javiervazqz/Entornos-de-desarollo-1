using System;

namespace DateTime
{
    public class DateTime
    {
        int _day;
        int _month;
        int _year;
        int _hour;
        int _minute;
        int _second;
        DateTime date = new DateTime(1, 1, 1, 1, 1, 1);
        public DateTime(int day, int month, int year)
        {
            _day = day;
            _month = month;
            _year = year;
        }
        public DateTime(int day, int month, int year, int hour, int minute, int second)
        {
            _day = day;
            _month = month;
            _year = year;
            _hour = hour;
            _minute = minute;
            _second = second;
        }
        public DateTime Clone()
        {

            int day = date._day;
            int month = date._month;
            int year = date._year;
            int hour = date._hour;
            int minute = date._minute;
            int second = date._second;
            DateTime time = new DateTime(day, month, year, hour, minute, second);
            return time;
        }
        public bool Equals(DateTime date, DateTime time)
        {
            if (date._day == time._day && date._year == time._year && date._month == time._month && date._hour == time._hour && date._minute == time._minute && date._second == time._second)
                return true;
            return false;
        }
        public bool IsValid()
        {

        }
        public bool IsLeap()
        {
            return (date._year % 4 == 0 && date._year % 100 != 0);
        }
        public bool IsLeap(int year)
        {
            return (year % 4 == 0 && year % 100 != 0);
        }
        public int GetDay()
        {
            return _day;
        }
        public int GetMonth()
        {
            return _year;
        }
        public int GetYear()
        {
            return _year;
        }
        public int GetSecond()
        {
            return _second;
        }
        public int GetMinute()
        {
            return _minute;
        }
        public int GetHour()
        {
            return _hour;
        }
        public string ToString()
        {
            return date._day + "/" + date._month + "/" + date._year;
        }
    }
}
