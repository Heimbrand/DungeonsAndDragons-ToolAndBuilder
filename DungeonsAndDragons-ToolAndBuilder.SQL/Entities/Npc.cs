using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Npc : IEntity<int>
{
    public int Id { get; set; }
    public Guid NpcGuid { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public List<Tag> NpcTags {get; set; }

}   