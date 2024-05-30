using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class MonsterTrait : IEntity<int>
{
    // Special traits that are unique to that monster
    
    public int Id { get; set; }
    public int MonsterId { get; set; }
    public string Name { get; set; } = default!;
    public string Description { get; set; }

}