using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LinqHowTos
{
    public static class CarParser
    {
        public static IEnumerable<Car> GetCarsFromCsv(string path)
        {
            return File.ReadAllLines(path)
                       .Where(line => line.Length > 1)
                       .Skip(1)
                       .Select(ParseCsvLine);
        }
        private static Car ParseCsvLine(string line)
        {
            var columns = line.Split(',');
            return new Car()
            {
                Id = int.Parse(columns[43]),
                Manufacturer = columns[46],
                Model = columns[47],
                Year = columns[63],
                Cylinders = ParseCylinders(columns[22])
            };
        }
        private static int ParseCylinders(string c)
        {
            int cylinders;
            int.TryParse(c, out cylinders);
            return cylinders;
        }

    }
}
