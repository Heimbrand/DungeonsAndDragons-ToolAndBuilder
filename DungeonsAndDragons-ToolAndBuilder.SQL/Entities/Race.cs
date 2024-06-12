using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Race : IEntity<int>
{
    public int Id { get; set; }
    public int CharacterId { get; set; }
    public int NpcId { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public string RaceImg { get; set; }
    public string? Speed { get; set; }

    public SubRace SubRace { get; set; }
    public RaceAction RaceActions { get; set; }
    public ICollection<Proficience> Proficiencies { get; set; }
   
}

