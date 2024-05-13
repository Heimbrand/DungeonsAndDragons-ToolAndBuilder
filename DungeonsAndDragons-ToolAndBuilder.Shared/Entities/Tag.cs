namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Tag
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public int WeaponId { get; set; }
    public int WorldId { get; set; }
    public int MonsterId { get; set; }
    public int SpellId { get; set; }
    public int ItemId { get; set; }
    public int ClassId { get; set; }
    public int RaceId { get; set; }
    public int CharacterId { get; set; }
    public int NpcId { get; set; }


}