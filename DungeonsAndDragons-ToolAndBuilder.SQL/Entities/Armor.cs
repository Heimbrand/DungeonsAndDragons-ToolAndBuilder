namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Armor : BaseEntity
{
    public Guid ArmorGuid { get; set; }
    public string? ArmorImg { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public int ArmorClass { get; set; }
    public string? ArmorType { get; set; } //Light, Medium, Heavy
    public string? ArmorPiece { get; set; } //Helmet, Chestplate, etc.
    public double? Weight { get; set; }
    public double? Cost { get; set; }
    public string? Rarity { get; set; }
    public string? MagicalEffects { get; set; }
    public bool IsPre5E { get; set; } = default!;

}