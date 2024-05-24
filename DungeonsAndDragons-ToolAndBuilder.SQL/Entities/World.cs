using System.ComponentModel.DataAnnotations;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class World
{
    public int Id { get; set; }
    [StringLength(50), RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Only alphabetic characters are allowed.")]
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public string? WorldUrl { get; set; }
    public List<Tag> WorldTags { get; set; } 


}


