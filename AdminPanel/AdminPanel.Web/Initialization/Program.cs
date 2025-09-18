using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace AdminPanel;
public class Program
{
    public static void Main(string[] args)
    {
        new AppServices.DynamicDataGenerator().RunAndExitIf(args);
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args)
    {
        return Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStaticWebAssets();
                webBuilder.UseStartup<Startup>();
                // Use environment variable or fallback to a safe default port
                var urls = Environment.GetEnvironmentVariable("ASPNETCORE_URLS");
                if (!string.IsNullOrWhiteSpace(urls))
                {
                    // If user sets ASPNETCORE_URLS, use it as-is
                    webBuilder.UseUrls(urls);
                }
                else
                {
                    // Use 127.0.0.1:5001 as a safe default (not localhost:0)
                    webBuilder.UseUrls("http://127.0.0.1:5001");
                }
            })
            .ConfigureAppConfiguration((builderContext, config) =>
            {
                config.AddJsonFile("appsettings.bundles.json");
                config.AddJsonFile("appsettings.machine.json", optional: true);
            });
    }
}