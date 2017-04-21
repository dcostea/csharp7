using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TupleGetMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 3, 8, 5, 9, 1, 2, 4 };

            (int max, int pos) = GetMax(array);

            WriteLine(string.Join(" ", array));
            WriteLine($"Max element {max} at position {pos + 1}");

            ReadKey();


            (int max, int pos) GetMax(int[] a)
            {
                var m = a[0];
                var p = 0;

                for (int i = 1; i < a.Length; i++)
                {
                    if (a[i] > m)
                    {
                        m = a[i];
                        p = i;
                    }
                }

                return (m, p);
            }
        }
    }
}
