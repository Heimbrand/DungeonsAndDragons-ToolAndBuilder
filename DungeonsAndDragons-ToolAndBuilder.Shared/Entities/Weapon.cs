namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Weapon
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Damage { get; set; }
    public string? Weight { get; set; }
    public string? Cost { get; set; }
    public List<Tag>? Tags { get; set; }
    public List<WeaponProperty>? Properties { get; set; }

    public Weapon(int id, string name, string? damage, string? weight, string? cost, List<Tag>? tags, List<WeaponProperty>? properties)
    {
        Id = id;
        Name = name ?? throw new ArgumentNullException(nameof(name),"Name cannot be null!");
        Damage = damage;
        Weight = weight;
        Cost = cost;
        Tags = tags;
        Properties = properties;
    }
}