using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace portalManutencao.WebApp
{
    using portalManutencao.Infrastructure.InMemoryDataAccess;
  
    public class Program
    {
        public static Context Base { get; set; }
        public static void Main(string[] args)
        {
            var cont = new DesignTimeDbContextFactory();
            Base = cont.CreateDbContext(null);
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

    }
}
