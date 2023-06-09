namespace RedRiftTest.Extensions;

public static class WebApplicationBuilderExtensions
{
    public static WebApplicationBuilder ConfigureServices(this WebApplicationBuilder @this)
    {
        var services = @this.Services;

        services.AddRazorPages();
        services.AddServerSideBlazor();

        return @this;
    }
}
