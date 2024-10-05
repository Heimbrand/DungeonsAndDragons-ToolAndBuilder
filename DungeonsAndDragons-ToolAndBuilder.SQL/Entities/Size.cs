namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Size : BaseEntity
{
    public int MonsterId { get; set; }
    public int CharacterId { get; set; }
    
    public string Name { get; set; } = default!;
    public bool IsPre5E { get; set; } = default!;
}