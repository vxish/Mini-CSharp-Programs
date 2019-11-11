using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesProject
{
    class Bus : MotorVehicle
    {
        public int NumberOfPassengers { get; set; }

        public Bus(String colour, Double engineSize, int numberOfPassengers) : base(colour, engineSize)
        {
            Colour = colour;
            EngineSize = engineSize;
            NumberOfPassengers = numberOfPassengers;
        }

        public override String ToString()
        {
            return "The " + Colour + " bus can carry " + NumberOfPassengers + " passengers and its engine size is " 
                + EngineSize + " liters";
        }
    }
}
