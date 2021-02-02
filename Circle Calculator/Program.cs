using System;

namespace Circle_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double cicleRadius = 7;
            double Diameter = 18;
            double circumference = 2 * Math.PI * cicleRadius;
            //circumference of a circle = 2xPi^r

            Console.WriteLine("the circumference is " + circumference);
        }
    }
}
