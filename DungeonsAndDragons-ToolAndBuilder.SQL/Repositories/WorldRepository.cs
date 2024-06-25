using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class WorldRepository(DnDbContext context) : IWorldRepository
{
    public async Task<World> GetByIdAsync(int id)
    {
        var worldById = await context.Worlds.FindAsync(id);

        if (worldById is null)
            throw new Exception("No World found with that ID");

        return worldById;
    }
    public async Task<IEnumerable<World>> GetAllAsync()
    {
        var allWorlds = await context.Worlds.ToListAsync();

        if (allWorlds is null)
            throw new Exception("No Worlds found");

        return allWorlds;
    }
    public async Task<IEnumerable<World>> GetMany(int start, int count)
    {
        var getManyWorlds = await context.Worlds.Skip(start).Take(count).ToListAsync();

        if (getManyWorlds is null)
            throw new Exception("No Worlds found");

        return getManyWorlds;
    }
    public async Task AddAsync(World entity)
    {
        var addWorld = await context.Worlds.AddAsync(entity);
        context.SaveChangesAsync();
    }
    public async Task UpdateAsync(World entity)
    {
        var oldWorld = await context.Worlds.FindAsync(entity.Id);

        if (oldWorld is null)
            throw new Exception("No World found with that ID");

        context.Entry(oldWorld).CurrentValues.SetValues(entity);
        context.SaveChangesAsync();
    }
    public async Task DeleteAsync(int id)
    {
        var worldToDelete = await context.Worlds.FindAsync(id);

        if (worldToDelete is null)
            throw new Exception("No World found with that ID");

        context.Worlds.Remove(worldToDelete);
        context.SaveChangesAsync();
    }
}