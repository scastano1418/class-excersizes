using System;

namespace AIE_14_Password_Prompt
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "";
            string matchingPassword = "";

            do
            {
                Console.Write("Enter a password: ");
                password = Console.ReadLine();

                Console.Write("Confirm a password: ");
                matchingPassword = Console.ReadLine();
                
              if (password != matchingPassword)
              {   
                 Console.WriteLine("Password Incorrect");
              }

              if (password == matchingPassword)
              {
                Console.WriteLine("Passwod Correct");
              }
            }
            while (password != matchingPassword);
            Console.WriteLine("Your password was confirmed");
            Console.WriteLine("Exiting");







        }
    }
}
