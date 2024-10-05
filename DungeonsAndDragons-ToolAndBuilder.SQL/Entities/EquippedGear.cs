namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class EquippedGear : BaseEntity
{
    // This class will get its information from the characters inventory and if the player wishes to equip an item, it will be added to this class.
    public int CharacterId { get; set; }
    public List<Armor?> Armours { get; set; } = new();
    public List<Weapon?> Weapons { get; set; } = new();
    public List<QuestItem?> QuestItems { get; set; } = new();
    public List<Consumable?> Consumables { get; set; } = new();
    public List<MiscellaneousItem?> MiscellaneousItems { get; set; } = new();
    public List<MagicalArtifact?> MagicalArtifacts { get; set; } = new();
}