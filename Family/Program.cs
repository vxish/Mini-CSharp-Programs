using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family
{
    class Program
    {
        static void Main(string[] args)
        {

            //Family details
            Person mom = new Person("Juliet", "", 68);
            Person dad = new Person("Romeo", "Montague", 42, 73);
            Person son = new Person("Triolus", "", 4, 33);
            Person daughter = new Person("Cressida", "", 6);

            //Output
            Console.WriteLine(mom.Name + mom.Height + " inches tall");
            Console.WriteLine(dad.Name + dad.Age + dad.Height + " inches tall");
            Console.WriteLine(son.Name + son.Age + son.Height + " inches tall");
            Console.WriteLine(daughter.Name + daughter.Age);

            Console.ReadLine();

        }
    }
}
