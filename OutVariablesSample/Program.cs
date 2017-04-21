using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OutVariablesSample
{
    class Program
    {
        static void Main(string[] args)
        {
            if (int.TryParse("42", out int x))
            {
                WriteLine($"the result is {x}");
            }


            GetCoordinates(out _, out int y); // I don't care about x!
            WriteLine($"the result is {y}");

            ReadKey();



            void GetCoordinates(out int a, out int b)
            {
                a = 42;
                b = 24;
            }
        }
    }
}
