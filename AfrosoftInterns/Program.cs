using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.Security.Authentication;

namespace AfrosoftInterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.ConfigureKestrel(serverOptions =>
                {
                    serverOptions.ConfigureHttpsDefaults(co =>
                    {
                        co.SslProtocols = SslProtocols.Tls12;
                    });
                }).UseStartup<Startup>();
            });
    }
}
