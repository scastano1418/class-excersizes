using System;

namespace AIE_12_Nine_Times_Tables
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int s = 0; s <= 15; s++)
            {
                Console.WriteLine($"{s} * 9: {s * 9}");
            }
        }
    }
}
