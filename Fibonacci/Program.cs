using System.Diagnostics;
using static System.Console;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = Stopwatch.StartNew();

            int n = 35;

            sw.Restart();
            Write("Fibonacci with tuple... ");
            Write(FibonacciWithTuple(n).current);
            sw.Stop();
            WriteLine($" - {sw.ElapsedMilliseconds} ms");

            sw.Restart();
            Write("Fibonacci with tuple and local function... ");
            Write(FibonacciWithTupleAndLocal(n));
            sw.Stop();
            WriteLine($" - {sw.ElapsedMilliseconds} ms");

            WriteLine("-----------------------------");

            sw.Restart();
            Write("Fibonacci classic... ");
            Write(Fibonacci(n));
            sw.Stop();
            WriteLine($" - {sw.ElapsedMilliseconds} ms");

            sw.Restart();
            Write("Fibonacci classic with local function... ");
            Write(FibonacciWithLocal(n));
            sw.Stop();
            WriteLine($" - {sw.ElapsedMilliseconds} ms");

            sw.Restart();
            Write("Fibonacci classic with local function and espression-bodied... ");
            Write(FibonacciWithLocalExpressionBodied(n));
            sw.Stop();
            WriteLine($" - {sw.ElapsedMilliseconds} ms");

            ReadKey();


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

        private static (long current, long previous) FibonacciWithTuple(int n) // Fibonacci as Method
        {
            if (n == 0) return (1, 0);
            var (curr, prev) = FibonacciWithTuple(n - 1);

            return (curr + prev, curr);
        }

        public static long FibonacciWithTupleAndLocal(int x)
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
