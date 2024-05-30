using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class SkillRepository : ISkillRepository
{
    public Task<Skill> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Skill>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Skill>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<Skill> AddAsync(Skill entity)
    {
        throw new NotImplementedException();
    }

    public Task<Skill> UpdateAsync(Skill entity)
    {
        throw new NotImplementedException();
    }

    public Task<Skill> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}