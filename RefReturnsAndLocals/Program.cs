using System;
using static System.Console;

namespace RefReturnsAndLocals
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {2,4,62,54,33,55,66,71,92};
            //int oddNum = GetFirstOddNumber(array); //storing as value  
            ref int oddNum = ref GetFirstOddNumber(array); //storing as reference  

            WriteLine($"\t\t\t\t{oddNum}");
            oddNum = 35;

            WriteLine(string.Join("\t", array));
            ReadKey();

            ref int GetFirstOddNumber(int[] numbers)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 1)
                    {
                        return ref numbers[i]; //returning as reference  
                    }
                }
                throw new Exception("odd number not found");
            }
        }
    }
}
