using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyPets
{
    class Program
    {
        static void Main(string[] args)
        {
            Person ann = new Person("Ann");
            Person bob = new Person("Bob");
            Person carl = new Person("Carl");

            Pet fluffy = new Pet("Fluffy");
            Pet goldie = new Pet("Goldie");
            Pet honk = new Pet("Honk");
            Pet iggy = new Pet("Iggy");
            Pet jaws = new Pet("Jaws");

            if (ann.AddPet(fluffy))
            {
                Console.WriteLine("Fluffy added");
            }
            else
            {
                Console.WriteLine("Fluffy not added");
            }

            if (ann.AddPet(fluffy))
            {
                Console.WriteLine("Fluffy added");
            }
            else
            {
                Console.WriteLine("Fluffy not added");
            }
            bob.AddPet(goldie);
            bob.AddPet(honk);

            printPersonDetails(ann);
            printPersonDetails(bob);
            printPersonDetails(carl);

            //test RemovePet
            if (ann.RemovePet(fluffy))
            {
                Console.WriteLine("Fluffy removed");
            }
            else
            {
                Console.WriteLine("Fluffy not removed");
            }

            if (ann.RemovePet(fluffy))
            {
                Console.WriteLine("Fluffy removed");
            }
            else
            {
                Console.WriteLine("Fluffy not removed");
            }
            printPersonDetails(ann);

            Console.ReadLine();
        }

        static void printPersonDetails(Person p)
        {
            Console.WriteLine(p.Name);
            foreach (Pet pet in p.Pets)
            {
                Console.WriteLine("\t" + pet.Name);
            }
        }

    }
}