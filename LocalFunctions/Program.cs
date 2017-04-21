using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LocalFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1000;

            WriteLine(FibonacciClassic(n));

            WriteLine(FibonacciWithLocal(n));

            WriteLine(GetTemperature(100));
        }


        #region Fibonacci Classic

        public static long FibonacciClassic(int x)
        {
            return Fibonacci(x).current;
        }

        private static (long current, long previous) Fibonacci(int n) // Fibonacci as Method
        {
            if (n == 0) return (1, 0);
            var (curr, prev) = Fibonacci(n - 1);

            return (curr + prev, curr);
        }

        #endregion


        #region Fibonacci Local

        public static long FibonacciWithLocal(int x)
        {
            return Fibonacci(x).current;

            (long current, long previous) Fibonacci(int n) // Fibonacci as Function
            {
                if (n == 0) return (1, 0);
                var (curr, prev) = Fibonacci(n - 1);

                return (curr + prev, curr);
            }
        }

        #endregion


        public static double GetTemperature(double temperature)
        {
            return CelsiusToFahrenheit(temperature);

            double CelsiusToFahrenheit(double temp)
            {
                return temp * 9 / 5 + 32;
            }
        }

    }
}
