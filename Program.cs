using Microsoft.AspNetCore.Hosting;

namespace AspNetCoreUbuntu
{
    public class Program
    {
       public static void Main(string[] args)
        {
            var host = HostBuilder()
                        .Build();

            host.Run();
        }

        private static IWebHostBuilder HostBuilder()
        {
            return new WebHostBuilder()
                                    .UseKestrel()
                                    .UseStartup<Startup>();
        }
    }
}
