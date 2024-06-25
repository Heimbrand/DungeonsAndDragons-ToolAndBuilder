using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class MiscellaneousItemRepository(DnDbContext context) : IMiscellaneousItemRepository
{
    public async Task<MiscellaneousItem> GetByIdAsync(int id)
    {
        var miscellaneousItemById = await context.MiscellaneousItems.FindAsync(id);

        if (miscellaneousItemById is null)
            throw new Exception("No MiscellaneousItem found with that ID");

        return miscellaneousItemById;
    }

    public async Task<IEnumerable<MiscellaneousItem>> GetAllAsync()
    {
        var allMiscellaneousItems = await context.MiscellaneousItems.ToListAsync();

        if (allMiscellaneousItems is null)
            throw new Exception("No MiscellaneousItems found");

        return allMiscellaneousItems;
    }

    public async Task<IEnumerable<MiscellaneousItem>> GetMany(int start, int count)
    {
        var manyMiscellaneousItems = await context.MiscellaneousItems.Skip(start).Take(count).ToListAsync();

        if (manyMiscellaneousItems is null)
            throw new Exception("No MiscellaneousItems found");

        return manyMiscellaneousItems;
    }

    public async Task AddAsync(MiscellaneousItem entity)
    {
        var addMiscellaneousItem = await context.MiscellaneousItems.AddAsync(entity);
        context.SaveChangesAsync();
    }

    public async Task UpdateAsync(MiscellaneousItem entity)
    {
        var oldMiscellaneousItem = await context.MiscellaneousItems.FindAsync(entity.Id);

        if (oldMiscellaneousItem is null)
            throw new Exception("No MiscellaneousItem found with that ID");

        context.Entry(oldMiscellaneousItem).CurrentValues.SetValues(entity);
        context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var miscellaneousItemToDelete = await context.MiscellaneousItems.FindAsync(id);

        if (miscellaneousItemToDelete is null)
            throw new Exception("No MiscellaneousItem found with that ID");

        context.MiscellaneousItems.Remove(miscellaneousItemToDelete);
        context.SaveChangesAsync();
    }
}