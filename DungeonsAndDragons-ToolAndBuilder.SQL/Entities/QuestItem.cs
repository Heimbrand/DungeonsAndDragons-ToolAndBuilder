using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class QuestItem : IEntity<int>
{
    public int Id { get; set; }
    public Guid QuestItemGuid { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public double? Weight { get; set; }
    

}