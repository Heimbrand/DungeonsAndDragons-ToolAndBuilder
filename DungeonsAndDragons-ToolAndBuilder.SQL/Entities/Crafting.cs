namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Crafting : BaseEntity
{ 
    // Unclear if this will be used, but it's here just in case.
    public string Name { get; set; } = default!;
    public ICollection<Tag>? Tags { get; set; }
    public bool IsPre5E { get; set; } = default!;

}