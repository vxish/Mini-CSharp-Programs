using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysToChristmas
{
    class Program
    {
        static void Main(string[] args)
        {

            int daysLeft = 0;
            string xmasDay;

            DateTime now = new DateTime(2017,11,28);            
            if (now.Month >= 12 && now.Day > 25)
            {
                DateTime endOfYear = new DateTime(2017, 12, 31);
                DateTime xmasNextYear = new DateTime(2018, 12, 25);
                daysLeft = endOfYear.DayOfYear - now.DayOfYear + xmasNextYear.DayOfYear;
                xmasDay = xmasNextYear.DayOfWeek.ToString();
            }
            else
            {
                DateTime xmasThisYear = new DateTime(2017, 12, 25);
                daysLeft = xmasThisYear.DayOfYear - now.DayOfYear;
                xmasDay = xmasThisYear.DayOfWeek.ToString();
                Console.WriteLine("There are " + daysLeft + " days to Christmas, which is on a " +  xmasDay);
            }

            Console.ReadLine();  
        }
    }
}
