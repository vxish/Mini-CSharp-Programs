using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerProject
{
    class Club
    {
        public string ClubName { get; set; }
        public Manager Manager { get; set; }

        public Club(string clubName)
        {
            ClubName = clubName;
        }
    }
}
