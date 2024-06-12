using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Class : IEntity<int>
{
    public int Id { get; set; }
    public int CharacterId { get; set; }
    public int NpcId { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public string? ClassImg { get; set; }
    public string? HitDice { get; set; }

    public SubClass? SubClass { get; set; }
    public ClassAction ClassActions { get; set; }
    public ICollection<Proficience> Proficiencies { get; set; }
    
}