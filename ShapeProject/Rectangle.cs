using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProject
{
    class Rectangle : Shape
    {
        private double Width;
        private double Height;

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;

        }

        public override double getArea
        {
            get { return Width * Height; }
        }


    }
}
