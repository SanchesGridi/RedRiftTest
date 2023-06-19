using Microsoft.EntityFrameworkCore;
using RedRiftTest.Database.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RedRiftTest.Database.Entities;

[Table("Heroes"), Index(nameof(Name), IsUnique = true), Index(nameof(Color), IsUnique = true)]
public class HeroEntity : IEntity<Guid>
{
    public Guid Id { get; set; }
    [MaxLength(255)]
    public string? Name { get; set; }
    [MaxLength(255)]
    public string? Color { get; set; }

    public virtual ICollection<ReplyEntity> Replies { get; set; } = new List<ReplyEntity>();
}
