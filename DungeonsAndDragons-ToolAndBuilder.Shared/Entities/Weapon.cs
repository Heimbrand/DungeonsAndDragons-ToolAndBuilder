namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Weapon
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string? Damage { get; set; } 
    public string? Weight { get; set; } 
    public string? Cost { get; set; } 
    public List<Tag>? Tags { get; set; } 
    public List<WeaponProperty>? Properties { get; set; }
    public DamageType? DamageType { get; set; }
    public WeaponType? WeaponType { get; set; }
}