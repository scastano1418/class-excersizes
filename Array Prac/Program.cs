using System;

namespace Array_Prac
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[] { "this", "is", "an", "array", "full", "of", "needle", "random", "stuff" };

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

            Console.WriteLine(FindNeedle(array));
        }

        static int FindNeedle(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == "needle")           
                return i;
            }

            return -1;
        }
    }
}

