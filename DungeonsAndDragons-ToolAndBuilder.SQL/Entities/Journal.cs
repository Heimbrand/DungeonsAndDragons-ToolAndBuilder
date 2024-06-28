namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Journal : BaseEntity
{
    public int CharacterId { get; set; }
    public int DungeonMasterId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
}