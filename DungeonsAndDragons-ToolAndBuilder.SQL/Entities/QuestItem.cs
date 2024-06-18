namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class QuestItem : BaseEntity
{
    public Guid QuestItemGuid { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public double? Weight { get; set; }
    

}