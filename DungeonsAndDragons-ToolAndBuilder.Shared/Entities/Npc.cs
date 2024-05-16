namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Npc
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public List<Tag> NpcTags {get; set; }

}   