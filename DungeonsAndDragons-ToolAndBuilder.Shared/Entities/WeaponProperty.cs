namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class WeaponProperty
{
    //Heavy, Two-Handed, Light, Finesse, Reach, Thrown, Ammunition, Loading, Special

    public int Id { get; set; }
    public string Name { get; set; } = default!;
   public int WeaponId { get; set; }

}