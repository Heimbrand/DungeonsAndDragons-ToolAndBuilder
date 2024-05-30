using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class WeaponType : IEntity<int>
{
    // blunt, piercing, slashing

    public int Id { get; set; }
    public int WeaponId { get; set; }
    public string Name { get; set; } = default!;
}