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

            double[] b = { 5.1, 7.1, 8.1, 3.1, 1.1, 2.1, 6.1 };

            WriteLine(string.Join<double>(",", b));
            WriteLine(string.Join<double>(",", Sort(b)));

            string[] c = { "ccc", "ddd", "aaa", "bbb", "xxx" };

            WriteLine(string.Join<string>(",", c));
            WriteLine(string.Join<string>(",", Sort(c)));


            ReadKey();
        }

        private static void SwapIfGreater<T>(ref T x, ref T y)
        {
            T temp;
            if (((IComparable)x).CompareTo(y) > 0)
            {
                temp = x;
                x = y;
                y = temp;
            }
        }

        private static T[] Sort<T>(T[] a)
        {
            T max;
            int pos;

            for (int i = 0; i < a.Length; i++)
            {
                (max, pos) = GetMax(a, i);
                SwapIfGreater(ref a[i], ref a[pos]);
            }

            return a;

            (T max, int pos) GetMax(T[] t, int index)
            {
                T m = t[index];
                var p = index;

                for (int i = index; i < a.Length; i++)
                {
                    if (((IComparable)m).CompareTo(a[i]) > 0)
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
