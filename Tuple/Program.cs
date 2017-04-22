using static System.Console;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 37;

            Write("Fibonacci numbers using tuples... ");
            WriteLine(FibonacciWithTuple(n).current);

            Write("Fibonacci numbers ... ");
            WriteLine(Fibonacci(n));

            ReadKey();
        }

        private static long Fibonacci(int n)
        {
            if (n <= 1) return 1;

            return Fibonacci(n - 2) + Fibonacci(n - 1);
        }

        private static (long current, long previous) FibonacciWithTuple(int n)
        {
            if (n == 0)
            {
                return (1, 0);
            }
            var (curr, prev) = FibonacciWithTuple(n - 1);

            return (curr + prev, curr);
        }
    }
}
