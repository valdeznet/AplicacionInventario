using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionInventario
{
    public class Date
    {
        private int _year;
        private int _month;
        private int _day;

        public Date(int year, int month, int day)
        {
            _year = year;
            _month = CheckMonth(month);
            _day = day;
        }

        private int CheckMonth(int month)
        {
            if (month>=1 && month<=12)
            throw new NotImplementedException();
        }
    }
}
