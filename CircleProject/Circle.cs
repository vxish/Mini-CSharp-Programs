using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleProject
{
    class Circle
    {
        private double radius;
        public double Radius {

            get { return radius; }

            set
            {
                if (value <= 0)
                {
                    throw new IndexOutOfRangeException("Given Radius: "+ value + "\nThis Radius is below or is equal to 0! Please enter a Radius larger than 0 & Try again.");
                }
                radius = value;
            }

            }

        public double Area { get; }


        public double Perimeter { get; }

        public double area
        {
            get
            {
                return (Math.PI * (radius * radius));
            }
        }

        public double perimeter
        {
            get
            {
                return (2 * Math.PI * radius);
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
            Perimeter = perimeter;
            Area = area;
        }

        public string ToString()
        {
            return "Radius: " + Radius + "\nPerimeter: " + Perimeter +
                "\nArea: " + Area;
        }


    }

}
