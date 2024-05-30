using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class TraitRepository : ITraitRepository
{
    public Task<Trait> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Trait>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Trait>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<Trait> AddAsync(Trait entity)
    {
        throw new NotImplementedException();
    }

    public Task<Trait> UpdateAsync(Trait entity)
    {
        throw new NotImplementedException();
    }

    public Task<Trait> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}