using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class AbilityRepository : IAbilityRepository
{
    public Task<Ability> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Ability>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Ability>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<Ability> AddAsync(Ability entity)
    {
        throw new NotImplementedException();
    }

    public Task<Ability> UpdateAsync(Ability entity)
    {
        throw new NotImplementedException();
    }

    public Task<Ability> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}