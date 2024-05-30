using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class SizeRepository : ISizeRepository
{
    public Task<Size> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Size>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Size>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<Size> AddAsync(Size entity)
    {
        throw new NotImplementedException();
    }

    public Task<Size> UpdateAsync(Size entity)
    {
        throw new NotImplementedException();
    }

    public Task<Size> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}