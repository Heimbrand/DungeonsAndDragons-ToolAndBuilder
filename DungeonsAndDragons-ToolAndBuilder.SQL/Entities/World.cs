using System.ComponentModel.DataAnnotations;
using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class World : IEntity<int>
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public string? WorldUrl { get; set; }
    public ICollection<Tag>? WorldTags { get; set; }
}


