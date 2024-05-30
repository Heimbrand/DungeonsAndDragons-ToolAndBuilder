using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class EventRepository : IEventRepository
{
    public Task<Event> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Event>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Event>> GetMany(int start, int count)
    {
        throw new NotImplementedException();
    }

    public Task<Event> AddAsync(Event entity)
    {
        throw new NotImplementedException();
    }

    public Task<Event> UpdateAsync(Event entity)
    {
        throw new NotImplementedException();
    }

    public Task<Event> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}