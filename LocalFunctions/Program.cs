using System.Diagnostics;
using static System.Console;

namespace LocalFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(GetTemperature(100));

            ReadKey();

            double GetTemperature(double temperature)
            {
                return CelsiusToFahrenheit(temperature);

                double CelsiusToFahrenheit(double temp)
                {
                    return temp * 9 / 5 + 32;
                }
            }
        }
    }
}
