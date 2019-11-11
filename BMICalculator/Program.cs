using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
           double height = heightInInches();
           double weight = weightInPounds();
           outputBMI(height,weight);
           Console.ReadLine();
        }

        static int heightInInches()
        {
            Console.WriteLine("Enter your height in feet: ");
            int foot = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your height in inches: ");
            int inches = int.Parse(Console.ReadLine());
            int height = (foot * 12) + inches;
            return height;
        }

        static int weightInPounds()
        {
            Console.WriteLine("Enter your weight in stones: ");
            int stones = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your weight in pounds: ");
            int pounds = int.Parse(Console.ReadLine());
            int weight = (stones * 14) + pounds;
            return weight;
        }

        static void outputBMI(double height, double weight)
        {
            double bmi = weight * (703 / (height*height));
            Console.WriteLine("BMI is " + bmi);
        }
    }
}
