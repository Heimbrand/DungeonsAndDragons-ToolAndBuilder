using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class SubClassRepository(DnDbContext context) : ISubClassRepository
{
    public async Task<SubClass> GetByIdAsync(int id)
    {
        var subClassById = await context.SubClasses.FindAsync(id);

        if (subClassById is null)
            throw new Exception("No SubClass found with that ID");

        return subClassById;
    }

    public async Task<IEnumerable<SubClass>> GetAllAsync()
    {
        var allSubClasses = await context.SubClasses.ToListAsync();

        if (allSubClasses is null)
            throw new Exception("No SubClasses found");

        return allSubClasses;
    }

    public async Task<IEnumerable<SubClass>> GetMany(int start, int count)
    {
        var getManySubClasses = await context.SubClasses.Skip(start).Take(count).ToListAsync();

        if (getManySubClasses is null)
            throw new Exception("No SubClasses found");

        return getManySubClasses;
    }

    public async Task AddAsync(SubClass entity)
    {
        var addSubClass = await context.SubClasses.AddAsync(entity);
        context.SaveChangesAsync();
    }

    public async Task UpdateAsync(SubClass entity)
    {
        var oldSubClass = await context.SubClasses.FindAsync(entity.Id);

        if (oldSubClass is null)
            throw new Exception("No SubClass found with that ID");

        context.Entry(oldSubClass).CurrentValues.SetValues(entity);
        context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var subClassToDelete = await context.SubClasses.FindAsync(id);

        if (subClassToDelete is null)
            throw new Exception("No SubClass found with that ID");

        context.SubClasses.Remove(subClassToDelete);
        context.SaveChangesAsync();
    }

    public async Task<SubClass> GetSubclassByCharacterId(int id)
    {
        var subClassByCharacterId = await context.SubClasses.Where(x => x.CharacterId == id).FirstOrDefaultAsync();

        if (subClassByCharacterId is null)
            throw new Exception("No SubClass found with that Character ID");

        return subClassByCharacterId;
    }

    public async Task<SubClass> GetSubClassByNpcId(int id)
    {
        var subClassByNpcId = await context.SubClasses.Where(x => x.NpcId == id).FirstOrDefaultAsync();

        if (subClassByNpcId is null)
            throw new Exception("No SubClass found with that NPC ID");

        return subClassByNpcId;
    }
}