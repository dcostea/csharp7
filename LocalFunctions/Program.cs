using System.Diagnostics;
using static System.Console;

namespace LocalFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = 100;

            WriteLine($"{degrees} Celsius -> {GetTemperature(degrees)} Fahrenheit");

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
