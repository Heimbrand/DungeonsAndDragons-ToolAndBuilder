using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Trait : IEntity<int>
{
    // Special traits that are unique to that monster, character, or npc. See DnDBeoynd MonsterCards for reference.
    
    public int Id { get; set; }
    public int MonsterId { get; set; }
    public int CharacterId { get; set; }
    public int NpcId { get; set; }
    public string Name { get; set; } = default!;
    public string Description { get; set; }

}