using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TupleSelectSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 7, 8, 3, 1, 2, 6 };

            WriteLine(string.Join<int>(",", a));
            WriteLine(string.Join<int>(",", Sort(a)));


            ReadKey(true);
        }

        private static int[] Sort(int[] a)
        {
            int max;
            int pos;

            for (int i = 0; i < a.Length; i++)
            {
                (max, pos) = GetMax(a, i);
                if (a[i] > a[pos])
                {
                    (a[i], a[pos]) = (a[pos], a[i]); // swap elements using tuples
                }
            }

            return a;

            (int max, int pos) GetMax(int[] t, int index)
            {
                int m = t[index];
                var p = index;

                for (int i = index; i < a.Length; i++)
                {
                    if (m > a[i])
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
