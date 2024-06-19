namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Race : BaseEntity
{
    public int CharacterId { get; set; }
    public int NpcId { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public string? RaceImg { get; set; }
    public bool IsPre5E { get; set; } = default!;




    public ICollection<Proficiency>? Proficiencies { get; set; }
    public ICollection<RacialTrait>? RacialTraits { get; set; }

}

