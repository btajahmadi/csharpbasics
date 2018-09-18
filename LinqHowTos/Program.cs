using System;
using System.Linq;

namespace LinqHowTos
{
    class Program
    {
        static void Main(string[] args)
        {
            Car.ProcessCars().Take(400).PrintToConsole();
        }
    }
}
