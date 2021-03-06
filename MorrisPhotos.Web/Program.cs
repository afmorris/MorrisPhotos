﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace MorrisPhotos.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseUrls("http://localhost:12345")
                .UseStartup<Startup>()
                .Build();
    }
}
