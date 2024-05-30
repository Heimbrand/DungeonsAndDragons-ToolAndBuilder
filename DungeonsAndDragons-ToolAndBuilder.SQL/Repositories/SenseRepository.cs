using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class SenseRepository : ISenseRepository
{
    public Task<Sense> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Sense>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Sense>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<Sense> AddAsync(Sense entity)
    {
        throw new NotImplementedException();
    }

    public Task<Sense> UpdateAsync(Sense entity)
    {
        throw new NotImplementedException();
    }

    public Task<Sense> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}