using System;
using System.Collections.Generic;
using System.Text;

namespace Zara.Reto0.Utils
{
    public static class DateTimeUtil {
        public static DateTime GetLastThursdayOfTheMonth(DateTime date) {
            var lastDayOfMonth = new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));

            while (lastDayOfMonth.DayOfWeek != DayOfWeek.Thursday)
                lastDayOfMonth = lastDayOfMonth.AddDays(-1);

            return lastDayOfMonth;
        }
    }
}
