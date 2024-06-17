using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Collections;

public class InventoryItems : BaseDocument
{
    public Armor? Armor { get; set; }
    public Weapon? Weapon { get; set; }
    public QuestItem? QuestItem { get; set; }
    public Consumable? Consumable { get; set; }
    public MiscellaneousItem? MiscellaneousItem { get; set; } 
    public MagicalArtifact? MagicalArtifact { get; set; }
}