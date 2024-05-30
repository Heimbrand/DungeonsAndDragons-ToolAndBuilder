using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Skill : IEntity<int>
{
    // Acrobatics, Animal Handling, Arcana, Athletics, Deception, History, Insight, Intimidation etc...


    public int Id { get; set; }
    public int MonsterId { get; set; }
    public int CharacterId { get; set; }
    public int NpcId { get; set; }
    public string Name { get; set; } = default!;
    public int Bonus { get; set; }
    public string Modifier { get; set; } 
}