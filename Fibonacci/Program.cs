using System.Diagnostics;
using static System.Console;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = Stopwatch.StartNew();

            Write("Please note a value grater than 35 will become dramatically slow.\nGet n: ");
            int n = int.Parse(ReadLine());

            sw.Restart();
            WriteLine($"\nFibonacci with value tuple (liniar complexity n)... {FibonacciWithValueTuple(n).current}");
            sw.Stop();
            WriteLine($"{sw.ElapsedMilliseconds} ms \n");

            sw.Restart();
            WriteLine($"Fibonacci with value tuple and local function... {FibonacciWithValueTupleAndLocal(n)}");
            sw.Stop();
            WriteLine($"{sw.ElapsedMilliseconds} ms \n");

            sw.Restart();
            WriteLine($"Fibonacci classic (exponential complexity 2^n)... {Fibonacci(n)}");
            sw.Stop();
            WriteLine($"{sw.ElapsedMilliseconds} ms \n");

            sw.Restart();
            WriteLine($"Fibonacci classic with local function... {FibonacciWithLocal(n)}");
            sw.Stop();
            WriteLine($"{sw.ElapsedMilliseconds} ms \n");

            sw.Restart();
            WriteLine($"Fibonacci classic with local function and espression-bodied... {FibonacciWithLocalExpressionBodied(n)}");
            sw.Stop();
            WriteLine($"{sw.ElapsedMilliseconds} ms \n");

            ReadKey(true);

            long FibonacciWithLocal(int x)
            {
                if (x <= 1) return 1;

                return FibonacciWithLocal(x - 2) + FibonacciWithLocal(x - 1);
            }

            long FibonacciWithLocalExpressionBodied(int x) => (x <= 1) ? 1 : FibonacciWithLocalExpressionBodied(x - 2) + FibonacciWithLocalExpressionBodied(x - 1);
        }

        public static long Fibonacci(int n)
        {
            if (n <= 1) return 1;

            return Fibonacci(n - 2) + Fibonacci(n - 1);
        }

        private static (long current, long previous) FibonacciWithValueTuple(int n) // Fibonacci as Method
        {
            if (n == 0) return (1, 0);
            var (curr, prev) = FibonacciWithValueTuple(n - 1);

            return (curr + prev, curr);
        }

        public static long FibonacciWithValueTupleAndLocal(int x)
        {
            return Fibonacci(x).current;

            (long current, long previous) Fibonacci(int n) // Fibonacci as Function
            {
                if (n == 0) return (1, 0);
                var (curr, prev) = Fibonacci(n - 1);

                return (curr + prev, curr);
            }
        }
    }
}
