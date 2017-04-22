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
            string number = "42";

            if (int.TryParse(number, out int x))
            {
                WriteLine($"the result is {x}");
            }

            GetCoordinates(out _, out int y); // I don't care about x!
            WriteLine($"the result is {y}");

            ReadKey();

            void GetCoordinates(out int a, out int b)
            {
                a = 1;
                b = 2;
            }
        }
    }
}
