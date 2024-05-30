using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class DamageType : IEntity<int>
{
    public int Id { get; set; }
    public int MonsterId { get; set; }
    public int CharacterId { get; set; }
    public int NpcId { get; set; }
    public string Name { get; set; } = default!;
    
}