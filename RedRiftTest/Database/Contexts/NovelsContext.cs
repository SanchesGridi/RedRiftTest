using Microsoft.EntityFrameworkCore;
using RedRiftTest.Database.Entities;

namespace RedRiftTest.Database.Contexts;

public class NovelsContext : DbContext
{
    public DbSet<HeroEntity> Heroes { get; set; }
    public DbSet<ReplyEntity> Replies { get; set; }

    public NovelsContext(DbContextOptions<NovelsContext> options) : base(options)
    {
        Database.EnsureCreated(); // todo: migrations ??? 
    }

    public async Task<IEnumerable<ReplyEntity>> GetOrderedRepliesAsync()
    {
        return await Replies.OrderBy(x => x.Order).ToListAsync().ConfigureAwait(false);
    }
}
