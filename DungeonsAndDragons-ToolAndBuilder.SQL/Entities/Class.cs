namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Class : BaseEntity
{
    public int CharacterId { get; set; }
    public int NpcId { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public string? ClassImg { get; set; }

  
    public ICollection<ClassFeature>? ClassFeatures { get; set; }
    public ICollection<Proficiency>? Proficiencies { get; set; }

}