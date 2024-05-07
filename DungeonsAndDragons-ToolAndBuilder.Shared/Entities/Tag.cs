namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Tag
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int WeaponId { get; set; }
    public int WorldId { get; set; }

    public Tag(int id, string name, int weaponId, int worldId)
    {
        Id = id;
        Name = name ?? throw new ArgumentNullException(nameof(name), "Name cannot be null!");
        WeaponId = weaponId;
        WorldId = worldId;
    }
}