using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> book = new List<Book>();

            for (int i = 0; i < 5; i++ )
            {
                Console.WriteLine("Enter the name of the book: " );
                String title = Console.ReadLine();

                Console.WriteLine("Enter the name of the title: ");
                String author = Console.ReadLine();

                if (author == "")
                {
                    book.Add(new Book(title));

                }
                else
                {
                    book.Add(new Book(title, author));
                }
            }

            for (int i = 0; i < book.Count; i++)
            {
                Console.WriteLine("\n" + book[i].Title + " " + book[i].Author);
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
