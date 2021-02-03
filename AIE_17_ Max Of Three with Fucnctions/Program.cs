using System;

namespace AIE_17__Max_Of_Three_with_Fucnctions
{
    class Program
    {
        static void Main(string[] args)
        {
            static int MaxOfThree(int a, int b, int c)
            {
                if (a >= b && a >= c) return a;
                else if (b >= a && b >= c) return b;
                else return c;
            }
        }
    }
}
