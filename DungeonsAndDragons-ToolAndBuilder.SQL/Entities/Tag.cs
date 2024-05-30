using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Shared.Entities;

public class Tag : IEntity<int>
{
    public int Id { get; set; }
    public int WorldId { get; set; } 
    public int CharacterId { get; set; } 
    public int MonsterId { get; set; } 
    public int NpcId { get; set; } 
    public int WeaponId { get; set; } 
    public int QuestItemId { get; set; }
    public int SideQuestId { get; set; }
    public int MiscellaneousItemId { get; set; } 
    public int HeirloomId { get; set; }
    public int MagicalArtifactId { get; set; }
    public int ArmorId { get; set; }
    public int EventId { get; set; }
    public int ConsumableId { get; set; }
    public string Name { get; set; } = default!;
    
}