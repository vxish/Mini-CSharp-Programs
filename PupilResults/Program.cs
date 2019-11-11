using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PupilResults
{
    class Program
    {
        static void Main(string[] args)
        {

            Pupil p1 = new Pupil("AAA");
            Pupil p2 = new Pupil("BBB" , 50, 54, 45);

            p1.Maths = 32;
            p1.English = -5;
            p1.Science = 90;

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
            Console.ReadLine();
        }
    }
}
