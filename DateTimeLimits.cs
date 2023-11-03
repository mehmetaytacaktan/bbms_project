using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formProject
{
    internal static class DateTimeLimits
    {
        //Last second of a month from now
        internal static DateTime Max()
        {
            DateTime temp = DateTime.Now.AddMonths(1);
            return new DateTime(temp.Year, temp.Month, temp.Day, 23, 59, 59);
        }
        //First second of today
        internal static DateTime Min()
        {
            DateTime temp = DateTime.Now;
            return new DateTime(temp.Year, temp.Month, temp.Day, 0, 0, 1);
        }
    }
}
