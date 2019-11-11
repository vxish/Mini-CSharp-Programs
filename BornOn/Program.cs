using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BornOn
{
    class Program
    {
        static void Main(string[] args)
        {
            int day;
            int month;
            int year;
            string dayOfWeek;

            Console.Write("Enter the Day you were born on: ");
            day = int.Parse(Console.ReadLine());

            Console.Write("Enter Month you were  born on: ");
            month = int.Parse(Console.ReadLine());

            Console.Write("Enter Year you were  born on: ");
            year = int.Parse(Console.ReadLine());


            DateTime doB = new DateTime(year, month, day);
            dayOfWeek = doB.DayOfWeek.ToString();
            Console.WriteLine("\n You were born on a " + dayOfWeek + "...");
            Console.ReadLine();

        }
        
    }
}
