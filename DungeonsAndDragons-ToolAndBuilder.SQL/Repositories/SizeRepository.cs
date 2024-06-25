using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class SizeRepository(DnDbContext context) : ISizeRepository
{
    public async Task<Size> GetByIdAsync(int id)
    {
        var sizeById = await context.Sizes.FindAsync(id);

        if (sizeById is null)
            throw new Exception("No Size found with that ID");

        return sizeById;
    }

    public async Task<IEnumerable<Size>> GetAllAsync()
    {
        var allSizes = await context.Sizes.ToListAsync();

        if (allSizes is null)
            throw new Exception("No Sizes found");

        return allSizes;
    }

    public async Task<IEnumerable<Size>> GetMany(int start, int count)
    {
        var getManySizes = await context.Sizes.Skip(start).Take(count).ToListAsync();

        if (getManySizes is null)
            throw new Exception("No Sizes found");

        return getManySizes;
    }

    public async Task AddAsync(Size entity)
    {
        var addSize = await context.Sizes.AddAsync(entity);
        context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Size entity)
    {
        var oldSize = await context.Sizes.FindAsync(entity.Id);

        if (oldSize is null)
            throw new Exception("No Size found with that ID");

        context.Entry(oldSize).CurrentValues.SetValues(entity);
    }

    public async Task DeleteAsync(int id)
    {
        var sizeToDelete = await context.Sizes.FindAsync(id);

        if (sizeToDelete is null)
            throw new Exception("No Size found with that ID");

        context.Sizes.Remove(sizeToDelete);
    }
}