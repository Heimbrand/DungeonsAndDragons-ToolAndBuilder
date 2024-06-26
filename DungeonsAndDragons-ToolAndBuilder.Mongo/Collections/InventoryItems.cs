using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Collections;

public class InventoryItems : BaseDocument
{
    public List<Armor>? Armors { get; set; }
    public List<Weapon>? Weapons { get; set; }
    public List<QuestItem>? QuestItems { get; set; }
    public List<Consumable> Consumables { get; set; }
    public List<MiscellaneousItem>? MiscellaneousItems { get; set; } 
    public List<MagicalArtifact>? MagicalArtifacts { get; set; }
}