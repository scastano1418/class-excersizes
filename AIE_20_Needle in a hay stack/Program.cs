using System;

namespace AIE_20_Needle_in_a_hay_stack
{
    class Program
    {
         static int FindNeedle(string[] words)
         {
            for(int i=0; i<words.Length; i++)
            {
                if (words[i] == "needle")
                    return i;
            }

            return -1;
        
        
        
         }
        static void Main(string[] args)
        {
            var strings = new string[] 
            { "hay", "junk", "hay", "hay", "moreJunk", "needle", "randomJunk" };

            int needleLocation = FindNeedle(strings);
            if ( needleLocation < 0)
            {
                Console.WriteLine("yo bro i couldn't find the needle");

            }
            else
            {
                Console.WriteLine("cuz i found the needle at location: " + needleLocation);
            }
        }
    }
}
