﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace FootballStarz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                     .ConfigureLogging((context, logging) =>
                     {
                         logging.AddAzureWebAppDiagnostics();
                         logging.AddConfiguration(context.Configuration.GetSection("Logging"));
                         logging.AddDebug();
                         logging.AddConsole();
                     })
                .UseStartup<Startup>()
                .Build();
    }
}
