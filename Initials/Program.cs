using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initials
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int spaceLocation = name.IndexOf(" ");

            String word = name.TrimStart(1);       
            Console.WriteLine("Your initial is " + word);
            Console.ReadLine();

        }
    }
}
