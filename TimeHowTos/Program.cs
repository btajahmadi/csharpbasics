using System;

namespace TimeHowTos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            var utcNow = DateTime.UtcNow;
            var now = DateTime.Now;
            Console.WriteLine($"UTC Now : {utcNow}");
            Console.WriteLine($"Now : {now}");
            Console.WriteLine(DateTime.UtcNow.Kind.ToString());

        }
    }
}
