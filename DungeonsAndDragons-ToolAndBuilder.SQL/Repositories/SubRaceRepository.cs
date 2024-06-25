using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class SubRaceRepository(DnDbContext context) : ISubRaceRepository
{
    public async Task<SubRace> GetByIdAsync(int id)
    {
        var subRaceById = await context.SubRaces.FindAsync(id);

        if (subRaceById is null)
            throw new Exception("No SubRace found with");

        return subRaceById;
    }

    public async Task<IEnumerable<SubRace>> GetAllAsync()
    {
        var allSubRaces = await context.SubRaces.ToListAsync();

        if (allSubRaces is null)
            throw new Exception("No SubRaces found");

        return allSubRaces;
    }

    public async Task<IEnumerable<SubRace>> GetMany(int start, int count)
    {
        var getManySubRaces = await context.SubRaces.Skip(start).Take(count).ToListAsync();

        if (getManySubRaces is null)
            throw new Exception("No SubRaces found");

        return getManySubRaces;
    }

    public async Task AddAsync(SubRace entity)
    {
        var addSubRace = await context.SubRaces.AddAsync(entity);
        context.SaveChangesAsync();
    }

    public async Task UpdateAsync(SubRace entity)
    {
        var oldSubRace = await context.SubRaces.FindAsync(entity.Id);

        if (oldSubRace is null)
            throw new Exception("No SubRace found");

        context.Entry(oldSubRace).CurrentValues.SetValues(entity);
        context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var subRaceToDelete = await context.SubRaces.FindAsync(id);

        if (subRaceToDelete is null)
            throw new Exception("No SubRace found");

        context.SubRaces.Remove(subRaceToDelete);
        context.SaveChangesAsync();
    }

    public async Task<SubRace> GetSubRaceByCharacterId(int id)
    {
        var subRaceByCharacterId = await context.SubRaces.Where(x => x.CharacterId == id).FirstOrDefaultAsync();

        if (subRaceByCharacterId is null)
            throw new Exception("No SubRace found");

        return subRaceByCharacterId;
    }

    public async Task<SubRace> GetSubRaceByNpcId(int id)
    {
        var subRaceByNpcId = await context.SubRaces.Where(x => x.NpcId == id).FirstOrDefaultAsync();

        if (subRaceByNpcId is null)
            throw new Exception("No SubRace found");

        return subRaceByNpcId;
    }
}