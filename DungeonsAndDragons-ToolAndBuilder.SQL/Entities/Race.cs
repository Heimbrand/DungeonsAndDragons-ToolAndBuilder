using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Race : BaseEntity
{
    public int CharacterId { get; set; }
    public int NpcId { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public string RaceImg { get; set; }
    

 

    public ICollection<Proficiency> Proficiencies { get; set; }
    public ICollection<RacialTrait> RacialTraits { get; set; }

}

