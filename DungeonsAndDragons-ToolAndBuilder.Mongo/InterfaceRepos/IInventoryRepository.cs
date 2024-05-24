using DungeonsAndDragons_ToolAndBuilder.Shared.Collections;
using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.Shared.Interfaces;

namespace DungeonsAndDragons_ToolAndBuilder.Mongo.InterfaceRepos;

public interface IInventoryRepository : ISqlRepository<Inventory> 
{
   Task<Inventory> GetByCharacterIdAsync(Character characterId);
   Task<Inventory> GetByNpcIdAsync(Npc npcId);

}