using System;
using System.IO;
using System.Xml.Serialization;

namespace SerializationHowTos
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order("Pampers for Mr. Asheghi", new Customer("KFG Ltd."));
            order.AddItem(new Product("Blue Pampers"), 15);
            order.AddItem(new Product("King Size Pampers"), 104);


            var serializer = new XmlSerializer(typeof(Order));
            using (var file = new FileStream("order.xml", FileMode.Create))
            {
                serializer.Serialize(file, order);
            }

            //Console.WriteLine("Hello World!");
        }
    }
}
