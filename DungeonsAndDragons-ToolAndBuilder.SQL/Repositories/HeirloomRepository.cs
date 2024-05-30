using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class HeirloomRepository : IHeirloomRepository
{
    public Task<Heirloom> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Heirloom>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Heirloom>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<Heirloom> AddAsync(Heirloom entity)
    {
        throw new NotImplementedException();
    }

    public Task<Heirloom> UpdateAsync(Heirloom entity)
    {
        throw new NotImplementedException();
    }

    public Task<Heirloom> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}