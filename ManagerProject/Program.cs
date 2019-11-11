using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("John");
            printManagerDetails(manager);

            Club club = new Club("Mellor Rangers");
            printClubDetails(club);

            manager.Club = club;
            printClubDetails(club);

            Console.ReadLine();
        }

        private static void printManagerDetails(Manager manager)
        {
            if (manager.Club == null)
            {
                Console.WriteLine(manager.Name + " does not have a club");
            }
            else
            {
                Console.WriteLine(manager.Name + "'s club is called " +
                                  manager.Club.ClubName);
            }
        }

        private static void printClubDetails(Club club)
        {
            if (club.Manager == null)
            {
                Console.WriteLine(club.ClubName + " does not have a manager");
            }
            else
            {
                Console.WriteLine(club.ClubName + "'s manager is called " +
                                  club.Manager.Name);
            }
        }
    }
}
