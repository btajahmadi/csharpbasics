using System;
using System.Linq;

namespace LinqHowTos
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = "vehicles.csv";

            var query = CarParser.GetCarsFromCsv(filePath);

            var twelveCylinderCars = (from car in query
                        where car.Cylinders == 12
                        orderby car.Year
                        select car)
                        .Take(5);
            twelveCylinderCars.PrintToConsole();
        }
    }
}
