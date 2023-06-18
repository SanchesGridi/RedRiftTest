using RedRiftTest.Database.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace RedRiftTest.Database.Entities;

[Table("Replies")]
public class ReplyEntity : IEntity<Guid>
{
    public Guid Id { get; set; }
    public uint Order { get; set; }
    public string? Text { get; set; }

    public virtual Guid HeroId { get; set; }
    public virtual HeroEntity? Hero { get; set; }
}
