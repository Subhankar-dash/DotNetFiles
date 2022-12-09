using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Date_Difference.Models
{

    public static class ext
    {
        public static void CalculateDifference(this DateTime start_Date, DateTime end_Date)
        {
            int startDays = start_Date.Day, startMonth = start_Date.Month, startYear = start_Date.Year, endDays = end_Date.Day, endMonth = end_Date.Month, endYear = end_Date.Year, startHour = start_Date.Hour, endHour = end_Date.Hour, endMinute = end_Date.Minute, startMinut = start_Date.Minute;
            DateTime difference;
            int[] monthsss = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int days;
            if (endMinute < startMinut)
            {
                endHour--;
                endMinute = endMinute + 60;
            }
            int Minutes = endMinute - startMinut;
            if (endHour < startHour)
            {
                endDays--;
                endHour = endHour + 24;
            }
            int Hourss = endHour - startHour;
            if (endDays < startDays)
            {
                endMonth--;
                int addMonth;
                addMonth = monthsss[startMonth - 1];
                if (endYear % 4 == 0 && endYear % 100 != 0)
                {
                    addMonth = 29;
                }
                endDays = endDays + addMonth;
            }
            days = endDays - startDays;
            int months;
            if (endMonth < startMonth)
            {
                endYear--;
                endMonth = endMonth + 12;
            }
            months = endMonth - startMonth;
            int years = endYear - startYear;
            if (days > 30)
            {
                months++;
            }
            if (months > 12)
            {
                months = months - 12;
                years++;
            }
            Console.WriteLine($"The Difference Between the Two date is {years} Years {months} Months {days} Days {Hourss} Hours {Minutes} Minutes");
            return;
        }
    }
}















