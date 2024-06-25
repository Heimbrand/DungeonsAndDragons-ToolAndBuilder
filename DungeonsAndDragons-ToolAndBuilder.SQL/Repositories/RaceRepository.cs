using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class RaceRepository(DnDbContext context) : IRaceRepository
{
    public async Task<Race> GetByIdAsync(int id)
    {
        var raceById = await context.Races.FindAsync(id);

        if (raceById is null)
            throw new Exception("no race with that ID found");

        return raceById;
    }

    public async Task<IEnumerable<Race>> GetAllAsync()
    {
        var allRaces = await context.Races.ToListAsync();

        if (allRaces is null)
            throw new Exception("No Races found");

        return allRaces;
    }

    public async Task<IEnumerable<Race>> GetMany(int start, int count)
    {
        var getManyRaces = await context.Races.Skip(start).Take(count).ToListAsync();

        if (getManyRaces is null)
            throw new Exception("No Races found");

        return getManyRaces;
    }

    public async Task AddAsync(Race entity)
    {
        var addRace = await context.AddAsync(entity);
        context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Race entity)
    {
        var oldRace = await context.Races.FindAsync(entity.Id);

        if (oldRace is null)
            throw new Exception("No Race found");

        context.Entry(oldRace).CurrentValues.SetValues(entity);
        context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var raceToDelete = await context.Races.FindAsync(id);

        if (raceToDelete is null)
            throw new Exception("No Race found");

        context.Remove(raceToDelete);
        context.SaveChangesAsync();
    }
}