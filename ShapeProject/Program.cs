using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Shape());
            shapes.Add(new Circle(2.0));
            shapes.Add(new Rectangle(5, 5));
            shapes.Add(new Triangle(4, 8));

            foreach (Shape s1 in shapes)
            {
                Console.WriteLine(s1.getArea);
            }
            Console.ReadLine();
        }
    }
}
