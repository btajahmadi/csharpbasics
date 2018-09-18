using System;
using System.Collections.Generic;

namespace LinqHowTos
{
    public static class ExtensionMethods
    {
        public static void PrintToConsole(this IEnumerable<Car> source)
        {
            foreach (var item in source)
            {
                Console.WriteLine($"{item.Manufacturer} {item.Model} {item.Year} {item.Cylinders}");
            }
        }
    }
}
