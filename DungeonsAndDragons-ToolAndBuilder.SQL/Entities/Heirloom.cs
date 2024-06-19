namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Heirloom : BaseEntity
{
    public Guid HeirloomGuid { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public double? Weight { get; set; }
    public bool IsPre5E { get; set; } = default!;


}