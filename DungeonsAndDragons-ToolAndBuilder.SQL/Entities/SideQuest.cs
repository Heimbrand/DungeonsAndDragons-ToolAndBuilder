using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class SideQuest : BaseEntity
{
    public string Name { get; set; } = default!;
    public string? Description { get; set; } 
    public string? Reward { get; set; } 
    public int? RecommendedLevel { get; set; }
    public ICollection<Tag>? Tags { get; set; } 

}