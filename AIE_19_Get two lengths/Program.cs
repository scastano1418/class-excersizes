using System;

namespace AIE_19_Get_two_lengths
{
    class Program
    {

        static int[] GetTwoLengths(string str1, string str2, string str3)
        {
            int[] result = new int[3];
            result[0] = str1.Length;
            result[1] = str2.Length;
            result[2] = str3.Length;
            return result;
        }
        // solution 1
        static void Main(string[] args)
        {
            var strLengths1 = GetTwoLengths("hello", "world", "hi");
            var strLengths2 = GetTwoLengths("", "hello world", "yes");
            var strLengths3 = GetTwoLengths("aaaa", "bbbbbbbbbbbbbbb", "creative mode");

            CustomConsole.WriteArray(strLengths1);

            CustomConsole.WriteArray(strLengths2);

            CustomConsole.WriteArray(strLengths3);


            
        }

      
    }

    class CustomConsole
    {
         public static void WriteArray(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }
        }
    }
}
// solution 2
//Console.WriteLine(strLengths1[1]); // 5
//.WriteLine(strLengths1[2]);

// Console.WriteLine(strLengths2[1]); // 11
//.WriteLine(strLengths2[2]);

// Console.WriteLine(strLengths3[0]); // 4
// Console.WriteLine(strLengths3[1]); // 15
// Console.WriteLine(strLengths3[2]);
