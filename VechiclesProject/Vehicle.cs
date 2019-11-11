using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesProject
{
    class Vehicle
    {
        public virtual String Colour { get; set; }

        public Vehicle(String colour)
        {
            Colour = colour;
        }
    }
}
