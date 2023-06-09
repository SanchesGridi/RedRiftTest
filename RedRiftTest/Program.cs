using RedRiftTest.Extensions;

var app = WebApplication.CreateBuilder(args).ConfigureServices().Build();
app.ConfigureMiddlewares().ConfigureRoutes().Run();
