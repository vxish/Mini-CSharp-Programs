using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Bike b1 = new Bike("red", 5, false);
            Bike b2 = new Bike("blue", 12, true);
            Car c1 = new Car("green", 1.6, 4);
            Bus bu1 = new Bus("yellow", 7, 42);

            Console.WriteLine(b1.ToString());
            Console.WriteLine(b2.ToString());
            Console.WriteLine(c1.ToString());
            Console.WriteLine(bu1.ToString());

            Console.ReadLine();
        }
    }
}
