using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Tag : BaseEntity
{
    public int WorldId { get; set; }
    public int CharacterId { get; set; }
    public int NpcId { get; set; }
    public int ClassId { get; set; }
    public int SubClassId { get; set; }
    public int RaceId { get; set; }
    public int SubRaceId { get; set; }
    public int MonsterId { get; set; }
    public int SideQuestId { get; set; }
    public int EventId { get; set; }
    public int FactionId { get; set; }
    public int AlignmentId { get; set; }
    public int SizeId { get; set; }
    public int ConditionId { get; set; }
    public int DamageTypeId { get; set; }
    public int GameActionId { get; set; }
    public int CraftingId { get; set; }
    public int LocationId { get; set; }
    public string Name { get; set; } = default!;

}