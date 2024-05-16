namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class SideQuest
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; } 
    public string? Reward { get; set; } 
    public int? RecommendedLevel { get; set; }
    public List<Tag>? Tags { get; set; } 

}