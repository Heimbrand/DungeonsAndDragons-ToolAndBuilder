using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class MagicalArtifact : IEntity<int>
{
    //Magical artifacts that arent weapons or armor, for exampel bag of holding, ring of invisibility, etc.

    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public double? Weight { get; set; } 
    public double? Cost { get; set; }
    public List<Tag> MagicalArtifactTags { get; set; }

}