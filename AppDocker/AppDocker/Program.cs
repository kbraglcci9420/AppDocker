using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace AppDocker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random randomizer = new Random();
            var num = randomizer.Next(1, 100);
            Console.WriteLine("Merhaba\nBugünkü þanslý numaran\n{0}", num);
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
