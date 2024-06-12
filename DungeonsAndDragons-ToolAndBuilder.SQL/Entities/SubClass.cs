using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class SubClass : IEntity<int>
{
    public int Id { get; set; }
    public int ClassId { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public string? SubClassImg { get; set; }

    
    public SubClassAction SubClassActions { get; set; }

    public ICollection<Proficience> Proficiencies { get; set; }
    


}