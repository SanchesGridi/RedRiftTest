using Microsoft.EntityFrameworkCore;
using RedRiftTest.Database.Contexts;

namespace RedRiftTest.Extensions;

public static class WebApplicationBuilderExtensions
{
    public static WebApplicationBuilder ConfigureServices(this WebApplicationBuilder @this)
    {
        var services = @this.Services;
        var configuration = @this.Configuration;
        var connectionString = configuration.GetConnectionString("NovelsConnection");

        services.AddDbContext<NovelsContext>(
            opt => opt.UseSqlServer(connectionString).UseLazyLoadingProxies()
        );
        services.AddRazorPages();
        services.AddServerSideBlazor();

        return @this;
    }
}
