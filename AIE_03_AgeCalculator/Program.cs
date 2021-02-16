using System;

namespace Age_Caluclator
{
    class Program
    {
        static void Main(string[] args)
        {
            uint currentYear = 2065;
            uint birthdayYear = 2003;
            uint age = currentYear - birthdayYear;

            Console.WriteLine("You are: " + age + " years old");


        }
    }
}
