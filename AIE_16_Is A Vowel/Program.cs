using System;

namespace AIE_16_Is_A_Vowel
{
    class Program
    {
        static bool IsAVowel(char character)
        {
            character = char.ToLower(character);
            if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
                return true;

         return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine( IsAVowel ('U') );
            Console.WriteLine( IsAVowel ('a') );
            Console.WriteLine( IsAVowel ('z') );
        }

    }
}
