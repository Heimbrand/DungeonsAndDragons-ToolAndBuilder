using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class LegendaryActionRepository : ILegendaryActionRepository
{
    public Task<LegendaryAction> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<LegendaryAction>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<LegendaryAction>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<LegendaryAction> AddAsync(LegendaryAction entity)
    {
        throw new NotImplementedException();
    }

    public Task<LegendaryAction> UpdateAsync(LegendaryAction entity)
    {
        throw new NotImplementedException();
    }

    public Task<LegendaryAction> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}