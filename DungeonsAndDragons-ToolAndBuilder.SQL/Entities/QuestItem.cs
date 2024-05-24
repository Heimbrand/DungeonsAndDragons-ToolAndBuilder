namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class QuestItem
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public string? Weight { get; set; }
    public List<Tag> QuestItemTags { get; set; }

}