using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Circle c1 = new Circle(23);
                Console.WriteLine(c1.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
