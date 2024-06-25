using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class HeirloomRepository(DnDbContext context) : IHeirloomRepository
{
    public async Task<Heirloom> GetByIdAsync(int id)
    {
        var heirloomById = await context.Heirlooms.FindAsync(id);

        if (heirloomById is null)
            throw new Exception("No Heirloom found with that ID");

        return heirloomById;
    }

    public async Task<IEnumerable<Heirloom>> GetAllAsync()
    {
        var allHeirlooms = await context.Heirlooms.ToListAsync();

        if (allHeirlooms is null)
            throw new Exception("No Heirlooms found");

        return allHeirlooms;
    }

    public async Task<IEnumerable<Heirloom>> GetMany(int start, int count)
    {
        var manyHeirlooms = await context.Heirlooms.Skip(start).Take(count).ToListAsync();

        if (manyHeirlooms is null)
            throw new Exception("No Heirlooms found");

        return manyHeirlooms;
    }

    public async Task AddAsync(Heirloom entity)
    {
        var addHeirloom = await context.Heirlooms.AddAsync(entity);
        context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Heirloom entity)
    {
        var oldHeirloom = await context.Heirlooms.FindAsync(entity.Id);

        if (oldHeirloom is null)
            throw new Exception("No Heirloom found with that ID");

        context.Entry(oldHeirloom).CurrentValues.SetValues(entity);
        context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var heirloomToDelete = await context.Heirlooms.FindAsync(id);

        if (heirloomToDelete is null)
            throw new Exception("No Heirloom found with that ID");

        context.Heirlooms.Remove(heirloomToDelete);
        context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Heirloom>> GetHeirloomsByAdventure(string adventure)
    {
        var heirloomsByAdventure = await context.Heirlooms.Where(h => h.RelatedAdventure == adventure).ToListAsync();

        if (heirloomsByAdventure is null)
            throw new Exception("No Heirlooms found");

        return heirloomsByAdventure;
    }
}