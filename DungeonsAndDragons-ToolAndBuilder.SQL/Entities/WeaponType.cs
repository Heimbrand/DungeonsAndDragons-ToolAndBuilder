namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class WeaponType
{
    // blunt, piercing, slashing

    public int Id { get; set; }
    public int WeaponId { get; set; }
    public string Name { get; set; } = default!;
}