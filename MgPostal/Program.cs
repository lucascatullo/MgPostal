

using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace MgPostal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseDefaultServiceProvider(op => op.ValidateScopes = false)
                .UseStartup<Startup>();
    }
}
