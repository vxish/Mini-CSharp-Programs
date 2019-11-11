using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerProject
{
    class Manager
    {
        public string Name { get; set; }

        private Club club;
        public Club Club
        {
            get { return club; }
            set
            {
                club = value;
                Club.Manager = this;
            }
        }

        public Manager(string name)
        {
            Name = name;
        }
    }
}
