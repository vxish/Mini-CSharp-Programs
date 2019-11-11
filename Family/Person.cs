using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family
{
    class Person
    {
        public string Forename { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Name
        {
            get { return Forename + " " + Surname; }
        }

        public int Height { get; set; }

        public Person (String forename, String surname)
        {
            Forename = forename;
            Surname = surname;

        }

        public Person(String forename, String surname, int age)
        {
            Forename = forename;
            Surname = surname;
            Age = age;


        }

        public Person(String forename, String surname, int age, int height)
        {
            Forename = forename;
            Surname = surname;
            Age = age;
            Height = height;
        }
    }

}

