namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class MonsterType : BaseEntity
{
    public int MonsterId { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public bool IsPre5E { get; set; } = default!;

}