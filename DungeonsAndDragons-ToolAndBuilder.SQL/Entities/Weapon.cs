using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Weapon : BaseEntity
{
    public Guid WeaponGuid { get; set; }
    public string Name { get; set; } = default!;
    public string? Damage { get; set; } 
    public double? Weight { get; set; } 
    public double? Cost { get; set; }
    public string? DamageType { get; set; } // bludgeoning, piercing, slashing
    public string? Properties { get; set; } // light, finesse, thrown, two-handed, versatile, ammunition, heavy, reach, loading, special
    public string? WeaponType { get; set; } // simple, martial, ranged, melee
    public string? Rarity { get; set; } // common, uncommon, rare, very rare, legendary

}