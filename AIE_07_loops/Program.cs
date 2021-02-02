using System;

namespace AIE_07_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            string sNumber = Console.ReadLine();
            int number = int.Parse(sNumber);

            if (number > 50)
            {
                Console.WriteLine("Bigger");
            }
            else if (number < 50)
            {
                Console.WriteLine("Smaller");
            }
            else
            {
                Console.WriteLine("SAME");
            }
        }
        
    }
}
