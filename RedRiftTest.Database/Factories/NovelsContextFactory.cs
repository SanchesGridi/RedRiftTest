using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using RedRiftTest.Database.Contexts;
using RedRiftTest.Database.Utils;

namespace RedRiftTest.Database.Factories;

internal class NovelsContextFactory : IDesignTimeDbContextFactory<NovelsContext>
{
    public NovelsContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<NovelsContext>()
            .UseSqlServer(Consts.ConnectionString)
            .UseLazyLoadingProxies();

        return new(builder.Options);
    }
}
