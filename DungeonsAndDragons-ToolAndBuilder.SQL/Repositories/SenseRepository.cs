using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class SenseRepository(DnDbContext context) : ISenseRepository
{
    public async Task<Sense> GetByIdAsync(int id)
    {
        var senseById = await context.Senses.FindAsync(id);

        if (senseById is null)
            throw new Exception("No Sense found with that ID");

        return senseById;
    }

    public async Task<IEnumerable<Sense>> GetAllAsync()
    {
       var allSenses = await context.Senses.ToListAsync();

        if (allSenses is null)
            throw new Exception("No Senses found");

        return allSenses;
    }

    public async Task<IEnumerable<Sense>> GetMany(int start, int count)
    {
         var getManySenses = await context.Senses.Skip(start).Take(count).ToListAsync();

         if (getManySenses is null)
            throw new Exception("No Senses found");

         return getManySenses;
    }

    public async Task AddAsync(Sense entity)
    {
        var addSense = await context.Senses.AddAsync(entity);
        context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Sense entity)
    {
        var oldSense = await context.Senses.FindAsync(entity.Id);

        if (oldSense is null)
            throw new Exception("No Sense found with that ID");

        context.Entry(oldSense).CurrentValues.SetValues(entity);
        context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var senseToDelete = await context.Senses.FindAsync(id);

        if (senseToDelete is null)
            throw new Exception("No Sense found with that ID");

        context.Senses.Remove(senseToDelete);
        context.SaveChangesAsync();
    }
}