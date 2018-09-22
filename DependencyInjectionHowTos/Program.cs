using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace DependencyInjectionHowTos
{
    public class Program
    {
        private static IDependencyThing _dep;

        public static void Main(string[] args, IDependencyThing dep1)
        {
            BuildWebHost(args).Run();
            _dep = dep1;
            if(_dep == null)
                Console.WriteLine("dep id null");

        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();


    }
}
