using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace LinqHowTos 
{
    public class Car
    {
        private int _id;
        public int Id
        {
            get
            {
                Console.WriteLine("Id getter");
                return _id;
            }
            set
            {
                Console.WriteLine("Id setter");
                _id =  value;
            }
        }
        public string Manufacturer { get; set; }
        public string Model {get; set;}
        public string Year { get; set; }
        public int Cylinders { get; set; }
        #region Parsing from CSV file
        private static Car ParseCsvLine(string line)
        {
                var columns = line.Split(',');
                return new Car() {
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
        public static IEnumerable<Car> GetCarsFromCsv(string path)
        {
            return File.ReadAllLines(path)
                       .Where(line => line.Length > 1)
                       .Skip(1)
                       .Select(Car.ParseCsvLine)
                       .ToList();
        }
        #endregion Parsing from CSV file
    }






}