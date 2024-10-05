namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class SubClass : BaseEntity
{
    public int CharacterId { get; set; }
   
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public string? SubClassImg { get; set; }
    public bool IsPre5E { get; set; } = default!;



    public ICollection<SubClassFeature>? SubClassFeatures { get; set; }
  
    


}