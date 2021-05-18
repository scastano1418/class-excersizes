using System;

namespace array_Prac_int
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myInts = new int[10] { 1200, 19, 27, 105, 44, 555, 63, 52, 87, 99 };

            for (int j = 0; j < 0 + 1; j++)
            {
                for (int i = 9; i > -1; i--)
                {
                    Console.WriteLine(myInts[i]);
                }
            } 
        }
    }
}
