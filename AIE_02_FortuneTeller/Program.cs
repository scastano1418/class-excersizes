using System;

namespace AIE_02_FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            uint numberOfChildren = 38;
            string partnersName = "requise";
            string geographicLocation = "jamaica";
            string jobTitle = "AIE game programming teacher";

            string output = string.Format(
                "You will be a {0} in {1}, and married to {2} with {3} kids",
                jobTitle, geographicLocation, partnersName, numberOfChildren);

            Console.WriteLine(output);
        }
    }
}
