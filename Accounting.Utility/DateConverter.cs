using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Utility
{
    public class DateConverter
    {
        public string MiladyToShamsy(DateTime miladiDate)
        {
            PersianCalendar pc = new PersianCalendar();
            return $"{pc.GetYear(miladiDate)}/{pc.GetMonth(miladiDate):00}/{pc.GetDayOfMonth(miladiDate):00}";
        }
    }
}
