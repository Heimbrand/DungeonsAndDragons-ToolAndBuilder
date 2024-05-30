using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class RarityRepository : IRarityRepository
{
    public Task<Rarity> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Rarity>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Rarity>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<Rarity> AddAsync(Rarity entity)
    {
        throw new NotImplementedException();
    }

    public Task<Rarity> UpdateAsync(Rarity entity)
    {
        throw new NotImplementedException();
    }

    public Task<Rarity> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}