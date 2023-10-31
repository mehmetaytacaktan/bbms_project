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
        internal static DateTime Max()
        {
            return DateTime.Now.AddMonths(1).Date;
        }
        internal static DateTime Min()
        {
            return DateTime.Now.Date;
        }
    }
}
