using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Weapon : IEntity<int>
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string? Damage { get; set; } 
    public string? Weight { get; set; } 
    public string? Cost { get; set; } 
   public List<Tag> WeaponTags { get; set; } 
    public List<WeaponProperty>? Properties { get; set; }
    public DamageType? DamageType { get; set; }
    public Rarity? Rarity { get; set; }
    public WeaponType? WeaponType { get; set; }
}