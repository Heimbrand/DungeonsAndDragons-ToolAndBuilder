using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class SubRace : IEntity<int>
{
    public int Id { get; set; }
    public int CharacterId { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public string SubRaceImg { get; set; }


    public ICollection<Proficiency> Proficiencies { get; set; }
    public ICollection<SubRacialTrait> SubRacialTraits { get; set; }

}