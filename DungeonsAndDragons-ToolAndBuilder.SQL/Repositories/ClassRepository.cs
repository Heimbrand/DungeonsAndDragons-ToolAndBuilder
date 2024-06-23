using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class ClassRepository(DnDbContext context) : IClassRepository
{
    public async Task<Class> GetByIdAsync(int id)
    {
        var classById = await context.Classes.FindAsync(id);

        if (classById is null)
            throw new Exception("No Class found with that ID");

        return classById;
    }
    public async Task<IEnumerable<Class>> GetAllAsync()
    {
        var allClasses = await context.Classes.ToListAsync();

        if (allClasses is null)
            throw new Exception("No classes found");

        return allClasses;
    }
    public async Task<IEnumerable<Class>> GetMany(int start, int count)
    {
        var getMany = context.Classes.Skip(start).Take(count);

        if (getMany is null)
            throw new Exception("No classes found");

        return getMany;
    }
    public async Task AddAsync(Class entity)
    {
        var addClass = await context.Classes.AddAsync(entity);
    }
    public async Task UpdateAsync(Class entity)
    {
        var updateClass = context.Classes.Update(entity);
    }
    public async Task DeleteAsync(int id)
    {
        var deleteClass = await context.Classes.FindAsync(id);

        if (deleteClass is null)
            throw new Exception("No class found with that ID");

        context.Classes.Remove(deleteClass);
    }
    public async Task<IEnumerable<Class>> GetClassByName(string name)
    {
        var classByName = await context.Classes.ToListAsync();

        var fuzzyScore = classByName.Select(x => new
        {
            Class = x,
            Score = FuzzySharp.Fuzz.Ratio(name, x.Name)
        })
            .Where(c => c.Score > 80)
            .OrderByDescending(c => c.Score)
            .Select(c => c.Class);

        if (fuzzyScore is null)
            throw new Exception("No class found with that name");

        return fuzzyScore;
    }
    public async Task<IEnumerable<Class>> GetAllPre5EClasses()
    {
        var pre5EClasses = await context.Classes.Where(c => c.IsPre5E == true).ToListAsync();

        if (pre5EClasses is null)
            throw new Exception("No Pre-5E classes found");

        return pre5EClasses;
    }
}