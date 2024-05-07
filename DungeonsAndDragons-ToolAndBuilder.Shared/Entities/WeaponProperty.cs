namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class WeaponProperty
{
    public int Id { get; set; }
    public string Name { get; set; }
   public int WeaponId { get; set; }

   public WeaponProperty(int id, string name, int weaponId)
   {
       Id = id;
       Name = name ?? throw new ArgumentNullException(nameof(name), "Name cannot be null!");
       WeaponId = weaponId;
   }
}