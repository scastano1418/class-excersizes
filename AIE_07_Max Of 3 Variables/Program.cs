using System;

namespace AIE_07_Max_Of_3_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            string sNum1 = Console.ReadLine();
            Console.Write("Enter second number ");
            string sNum2 = Console.ReadLine();
            Console.Write("Enter third number ");
            string sNum3 = Console.ReadLine();

            int num1 = int.Parse(sNum1);
            int num2 = int.Parse(sNum2);
            int num3 = int.Parse(sNum3);

            Console.WriteLine("The biggest number is: ");

            if (num1 >= num2 && num1 >= num3) Console.WriteLine(num1);
            if (num2 >= num1 && num2 >= num3) Console.WriteLine(num2);
            if (num3 >= num1 && num3 >= num2) Console.WriteLine(num3);
        }
    }
}
