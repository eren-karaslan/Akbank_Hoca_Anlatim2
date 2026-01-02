using Microsoft.AspNetCore.Builder;

namespace VbApi;

public class Program
{
    public static void Main(String[] args)
    {
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            { 
                webBuilder.UseStartup<Startup>();
            }).Build().Run();
    }
}
