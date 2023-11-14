using System;
using System.Security.Cryptography.X509Certificates;

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
            return new DateTime(_day, _month, _year, _hour, _minute, _second);
        }
        public bool Equals(DateTime date, DateTime time)
        {
            if (date._day == time._day && date._year == time._year && date._month == time._month && date._hour == time._hour && date._minute == time._minute && date._second == time._second)
                return true;
            return false;
        }
        public bool IsValid()
        {
            if (_day < 0 || _day > 31 || _month < 0 || _month > 12 || _year < 0 || _hour > 24 || _hour < 0 || _minute > 60 || _minute < 0 || _second > 60 || _second < 0)
                return false;
            if (IsLeap())
            {
                if (_day < 0 || _day > 29 || _month < 0 || _month > 12 || _year < 0 || _hour > 24 || _hour < 0 || _minute > 60 || _minute < 0 || _second > 60 || _second < 0)
                    return false;
            }
            if (_month == 2)
            {
                if (_day < 0 || _day > 28 || _month < 0 || _month > 12 || _year < 0 || _hour > 24 || _hour < 0 || _minute > 60 || _minute < 0 || _second > 60 || _second < 0)
                    return false;
            }
            return true;
        }
        public bool IsLeap()
        {
            return IsLeap(_year);
        }
        public static bool IsLeap(int year)
        {
            return year % 4 == 0 && year % 100 != 0;
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
            return _day + "/" + _month + "/" + _year;
        }
        public void IncrementDay()
        {
            if (_day == 31)
                _month++;
            if (_day == 31 && _month == 12)
                _year++;
            _day++;
        }
        public string DayOfWeek()
        {
            int k = _year % 100;
            int q = _day;
            int m = _month;
            int j = _year / 100;
            if (_month == 1)
                m = 13;
            if (_month == 2)
                m = 14;
            int h = (_day + (13 * (_month + 1) / 5) + _year % 100 + (_year % 100 / 4) + (_year / 100 / 4) + 5 * _year / 100) % 7;
            switch (h)
            {
                case 0:
                    return "Sábado";
                    break;
                case 1:
                    return "Domingo";
                    break;
                case 2:
                    return "Lunes";
                    break;
                case 3:
                    return "Martes";
                    break;
                case 4: 
                    return "Miércoles";
                    break;
                case 5:
                    return "Jueves";
                    break;
                default:
                    return "Viernes";
                    break;
            }
        }
        public static int GetDaysCount(int year, int month)
        {
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 9 || month == 11)
                return 31;
            if (month == 2)
                return IsLeap(year) ? 28 : 29;
            return 30;
        }
    }
}
