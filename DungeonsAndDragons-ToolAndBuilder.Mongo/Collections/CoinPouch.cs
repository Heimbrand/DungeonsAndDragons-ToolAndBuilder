namespace DungeonsAndDragons_ToolAndBuilder.Shared.Collections;

public class CoinPouch : BaseDocument
{
    public int PlatinumPieces { get; set; } // 1 platinum = 10 gold
    public int GoldPieces { get; set; } // 1 gold = 100 copper
    public int SilverPieces { get; set; } // 1 gold = 10 silver
    public int CopperPieces { get; set; } // 1 silver = 10 copper
    public int ElectrumPieces { get; set; } // 1 gold = 2 electrum
}