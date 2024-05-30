using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Rarity : IEntity<int>
{
    public int Id { get; set; }
    public int WeaponId { get; set; }
    public int ArmorId { get; set; }
    public string Name { get; set; } = default!;
    
}