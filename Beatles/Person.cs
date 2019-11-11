using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beatles
{
    class Person
    {
        public string Forname { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public string Name
        {
            get { return Forname + " " + Surname; }
        }

    }
}
