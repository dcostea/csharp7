using System;
using static System.Console;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuple<double, double> coordinates0 = GetCoordinates0("some address");
            WriteLine("Using Tuple class:");
            WriteLine($"Lat: {coordinates0.Item1}, Long: {coordinates0.Item2}\n");

            ValueTuple<double, double> coordinates1 = GetCoordinates1("some address");
            WriteLine("Using ValueTuple class:");
            WriteLine($"Lat: {coordinates1.Item1}, Long: {coordinates1.Item2}\n");

            var coordinates2 = GetCoordinates1("some address");
            WriteLine("Using var with named items:");
            WriteLine($"Lat: {coordinates2.latitude}, Long: {coordinates2.longitude}\n");
            WriteLine("Using var:");
            WriteLine($"Lat: {coordinates2.Item1}, Long: {coordinates2.Item2}\n");

            (double latitude1, double longitude1) = GetCoordinates1("some address");
            WriteLine("Using short notation with named items:");
            WriteLine($"Lat: {latitude1}, Long: {longitude1}\n");

            (var latitude2, var longitude2) = GetCoordinates1("some address");
            WriteLine("Using short notation with var and named items:");
            WriteLine($"Lat: {latitude2}, Long: {longitude2}\n");

            var coords2 = GetCoordinates2("some address");
            WriteLine("Using var and default items:");
            WriteLine($"Lat: {coords2.Item1}, Long: {coords2.Item2}\n");

            ReadKey(true);
        }

        private static Tuple<double, double> GetCoordinates0(string address)
        {
            var randomizer = new Random();
            System.Threading.Thread.Sleep(300);

            var latitude = Math.Round(180 * randomizer.NextDouble(), 2);
            var longitude = Math.Round(180 * randomizer.NextDouble(), 2);

            var coord = new Tuple<double, double>(latitude, longitude);
            return coord;
        }

        private static (double latitude, double longitude) GetCoordinates1(string address)
        {
            var randomizer = new Random();
            System.Threading.Thread.Sleep(300);
            
            var latitude = Math.Round(180 * randomizer.NextDouble(), 2);
            var longitude = Math.Round(180 * randomizer.NextDouble(), 2);

            return (latitude, longitude);
        }

        private static (double, double) GetCoordinates2(string address)
        {
            var randomizer = new Random();
            System.Threading.Thread.Sleep(300);

            var latitude = Math.Round(180 * randomizer.NextDouble(), 2);
            var longitude = Math.Round(180 * randomizer.NextDouble(), 2);

            return (latitude, longitude);
        }
    }
}
