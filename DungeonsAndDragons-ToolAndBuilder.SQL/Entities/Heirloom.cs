namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Heirloom
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public List<Tag> HeirloomTags { get; set; }

}