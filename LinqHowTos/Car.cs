using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace LinqHowTos 
{
    public class Car
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model {get; set;}
        public string Year { get; set; }
        public int Cylinders { get; set; }
        public static IEnumerable<Car> ProcessCars()
        {
            var vehicles = File.ReadAllLines("vehicles.csv")
                                .Where(line => line.Length > 1).Skip(1);
            
            foreach (var vehicle in vehicles)
            {
                var columns = vehicle.Split(',');
                yield return new Car() {
                    Id = int.Parse(columns[43]),
                    Manufacturer = columns[46],
                    Model = columns[47],
                    Year = columns[63],
                    Cylinders = ProcessCylinders(columns[22])
                    };
            }
        }

        private static int ProcessCylinders(string c)
        {
            int cylinders;
            int.TryParse(c, out cylinders);
            return cylinders;
        }
    }



}