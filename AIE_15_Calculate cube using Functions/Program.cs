using System;

namespace AIE_15_Calculate_cube_using_Functions
{
    class Program
    {
        static float CalculateCube(float x)
        {
            return MathF.Pow(x, 3);
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateCube(5));
            Console.WriteLine(CalculateCube(10));
        }
        
    }
}
