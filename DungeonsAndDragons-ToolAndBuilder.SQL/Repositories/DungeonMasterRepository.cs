using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;
using Microsoft.Identity.Client;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class DungeonMasterRepository(DnDbContext context) : IDungeonMasterRepository
{
    public async Task AddAsync(DungeonMaster entity)
    {
        var result = context.DungeonMasters.AddAsync(entity);
        context.SaveChanges();
    }
    public async Task DeleteAsync(int id)
    {
        var oldEntity = await context.DungeonMasters.FindAsync(id);

        if (oldEntity is null)
            throw new InvalidOperationException("Entity not found");

        context.DungeonMasters.Remove(oldEntity);
        context.SaveChanges();
    }
    public async Task<IEnumerable<DungeonMaster>> GetAllAsync()
    {
       var allDms = context.DungeonMasters.ToList();

       if (allDms is null)
           throw new InvalidOperationException("No Dungeon Masters found");

       return allDms;
    }
    public async Task<DungeonMaster> GetByIdAsync(int id)
    {
        var dmById = await context.DungeonMasters.FindAsync(id);

        if (dmById is null)
            throw new InvalidOperationException("Dungeon Master not found");

        return dmById;
    }
    public async Task<IEnumerable<DungeonMaster>> GetMany(int start, int count)
    {
       var manyDms = context.DungeonMasters.Skip(start).Take(count).ToList();

       if (manyDms is null)
              throw new InvalidOperationException("No Dungeon Masters found");

       return manyDms;
    }
    public async Task UpdateAsync(DungeonMaster entity)
    {
        var dmToUpdate = await context.DungeonMasters.FindAsync(entity.Id);

        if (dmToUpdate is null)
            throw new InvalidOperationException("Dungeon Master not found");

        context.Entry(dmToUpdate).CurrentValues.SetValues(entity);
        context.SaveChanges();
    }
}