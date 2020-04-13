using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(CovidHelp.Areas.Identity.IdentityHostingStartup))]
namespace CovidHelp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}