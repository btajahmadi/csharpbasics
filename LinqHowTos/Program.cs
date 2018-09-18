using System;
using System.Linq;

namespace LinqHowTos
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = "vehicles.csv";

            Car.GetCarsFromCsv(filePath).Take(5).PrintToConsole();
            Console.ReadKey();
        }
    }
}
