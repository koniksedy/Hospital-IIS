using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Nemocnice.Data;
using Nemocnice.DatabaseDataCreator;


/*
 * P�id�na uk�zka pro pr�ci s datab�z�.
 * ------------------------------------
 * �pravy:
 * 14.10.2020 - vytvo�en� �ablony - xsedym02
 */


namespace Nemocnice
{
    public class Program
    {

        public static void Main(string[] args)
        {

            //DatabaseCreatorController Content = new DatabaseCreatorController();
            //Content.DatabaseContentCreate();

           
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
