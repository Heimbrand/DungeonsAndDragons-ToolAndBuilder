using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Proficience : IEntity<int>
{
    public int Id { get; set; }
    public int ClassId { get; set; }
    public int SubClassId { get; set; }
    public int RaceId { get; set; }
    public int SubRaceId { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public string? Prerequisite { get; set; } // i.e. "Dwarf", "Elf", "Fighter", "Rogue", etc.

}