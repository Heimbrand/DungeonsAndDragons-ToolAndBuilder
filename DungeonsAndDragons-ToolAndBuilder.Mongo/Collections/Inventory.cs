using MongoDB.Bson;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Collections;

public class Inventory : BaseDocument
{
    public ObjectId CharacterGuid { get; set; }
    public string Name { get; set; } = default!;
    public double MaxWeight { get; set; }
    public double CurrentWeight { get; set; }
    public string? InventoryImg { get; set; }
    public bool IsEncumberenceOff { get; set; } // if the player can be encumbered or not
    public bool IsEncumbered { get; set; } // if the player is encumbered or not

    public InventoryItems Items { get; set; } = default!;
    public CoinPouch CoinPouch { get; set; } = default!;

}