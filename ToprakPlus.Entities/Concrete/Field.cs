using System.ComponentModel.DataAnnotations.Schema;
using ToprakPlus.Core.Entities;

namespace ToprakPlus.Entities;

[Table("Field")]
public class Field : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    
}