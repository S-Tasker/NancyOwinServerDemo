using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace NancyOwinServerDemo
{
    class Program
    {
        public static IWebHost _webApp;
        private const string baseUrl = "http://localhost:9000";

        static void Main(string[] args)
        {
            _webApp = new WebHostBuilder()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseKestrel()
                .UseStartup<Startup>()
                .UseUrls(baseUrl)
                .Build();

            _webApp.Start();

            Console.ReadLine();
        }
    }
}
