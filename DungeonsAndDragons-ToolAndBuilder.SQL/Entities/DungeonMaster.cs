namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class DungeonMaster : BaseEntity
{
    public string? Name { get; set; } 
    public string? DmNotes { get; set; }
    public Journal? Journal { get; set; }
    public List<Event>? Events { get; set; }
    public List<Location>? Locations { get; set; }
    public List<SideQuest>? SideQuests { get; set; }
}