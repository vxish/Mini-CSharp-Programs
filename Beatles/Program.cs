using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beatles
{
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person();
            Person paul = new Person();
            Person george = new Person();
            Person ringo = new Person();

            john.Forname = "John";
            john.Surname = "Lennon";
            john.Age = 77;

            paul.Forname = "Paul";
            paul.Surname = "McCartney";
            paul.Age = 75;

            george.Forname = "George";
            george.Surname = "Harrison";
            george.Age = 74;

            ringo.Forname = "Ringo";
            ringo.Surname = "Starr";
            ringo.Age = 77;

            Console.WriteLine(john.Name + ", " + "born on 8th October 1940, Age today would've been: " + john.Age);
            Console.WriteLine(paul.Name + ", " + "born on 18th June 1942, Age today would've been: " + paul.Age);
            Console.WriteLine(george.Name + ", " + "born on 25th February 1943, Age today would've been: " + george.Age);
            Console.WriteLine(ringo.Name + ", " + "born on 7th July 1940, Age today would've been: " + ringo.Age);


            Console.ReadLine();

        }
    }
}
