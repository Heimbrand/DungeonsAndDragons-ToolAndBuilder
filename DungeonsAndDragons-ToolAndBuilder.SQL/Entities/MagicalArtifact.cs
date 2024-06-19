namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class MagicalArtifact : BaseEntity
{
    //Magical artifacts that arent weapons or armor, for exampel bag of holding, ring of invisibility, etc.

    public Guid MagicalArtifactGuid { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public double? Weight { get; set; } 
    public double? Cost { get; set; }
    public bool IsPre5E { get; set; } = default!;


}