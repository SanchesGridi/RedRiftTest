using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RedRiftTest.Database.Entities.Base;

public interface IEntity<TAny>
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    TAny Id { get; set; }
}
