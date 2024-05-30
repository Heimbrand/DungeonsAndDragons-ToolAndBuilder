using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class AlignmentRepository : IAlignmentRepository
{
    public Task<Alignment> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Alignment>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Alignment>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<Alignment> AddAsync(Alignment entity)
    {
        throw new NotImplementedException();
    }

    public Task<Alignment> UpdateAsync(Alignment entity)
    {
        throw new NotImplementedException();
    }

    public Task<Alignment> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}