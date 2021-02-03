using System;

namespace AIE_13_All_Times_Tables
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
            }
        }
    }
}

        // long version:
        // for (int a = 0; a < 11; a++)
        // Console.WriteLine($"{a} * 0: {a * 0}");

//for (int b = 0; b < 11; b++)
//  Console.WriteLine($"{b} * 1: {b * 1}");