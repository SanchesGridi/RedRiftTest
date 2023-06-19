using Microsoft.EntityFrameworkCore;
using RedRiftTest.Database.Contexts;
using RedRiftTest.Mapper.Profiles;

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
        services.AddAutoMapper(x =>
        {
            x.AddProfile<HeroProfile>();
            x.AddProfile<ReplyProfile>();
        });
        services.AddRazorPages();
        services.AddServerSideBlazor();

        return @this;
    }
}
