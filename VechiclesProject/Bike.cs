using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesProject
{
    class Bike : Vehicle
    {
        public int Gears { get; set; }

        public Boolean Bell { get; set; }

        public Bike(String colour, int gear, Boolean bell) : base(colour)
        {
            Colour = colour;
            Gears = gear;
            Bell = bell;
        }

        public override String ToString()
        {
            if (Bell == false)
            {
                return "The " + Colour + " bike has " + Gears + " gears and no bell";
            }
            else
            {
                return "The " + Colour + " bike has " + Gears + " gears and a bell";
            }
        }
    }
}
