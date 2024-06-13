using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class GameAction : IEntity<int>
{
    public int Id { get; set; }
    public int MonsterId { get; set; }
    public int CharacterId { get; set; }
    public int NpcId { get; set; }

    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string? Damage { get; set; }
    public string? ActionImg { get; set; }

    public bool IsLegendary { get; set; }
    public bool IsClassSpecific { get; set; }
    public bool IsSubClassSpecific { get; set; }
    public bool IsRaceSpecific { get; set; }
    public bool IsSubRaceSpecific { get; set; }
    public bool IsMonsterSpecific { get; set; }
    public bool IsNpcSpecific { get; set; } //Potential homebrew stuff



}