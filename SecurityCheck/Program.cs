using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityCheck
{
    class Program
    {
        static void Main(string[] args)
        {

            string password = "password";
            Random r = new Random();
  
            int index = r.Next(0, password.Length);
            string ch = password.Substring(index, 1);

            Console.Write("Enter the chrachter at location " + (index + 1) + ": ");
            string userInput = Console.ReadLine();
            
            if (ch.Equals(userInput, StringComparison.Ordinal))
            {
                Console.Write("OK...");

            }
            else
            {
                Console.Write("Not OK!");
            }
            Console.ReadLine();
        }
    }
}
