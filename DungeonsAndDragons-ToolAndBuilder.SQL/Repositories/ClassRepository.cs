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
        throw new NotImplementedException();
    }

    public async Task AddAsync(Class entity)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateAsync(Class entity)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Class>> GetClassByName(string name)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Class>> GetAllPre5EClasses()
    {
        throw new NotImplementedException();
    }
}