using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class EventRepository(DnDbContext context) : IEventRepository
{
    public async Task<Event> GetByIdAsync(int id)
    {
        var eventById = await context.Events.FindAsync(id);

        if (eventById is null)
            throw new Exception("No Event found with that ID");

        return eventById;
    }

    public async Task<IEnumerable<Event>> GetAllAsync()
    {
        var allEvents = await context.Events.ToListAsync();

        if (allEvents is null)
            throw new Exception("No Events found");

        return allEvents;
    }

    public async Task<IEnumerable<Event>> GetMany(int start, int count)
    {
        var getManyEvents = await context.Events.Skip(start).Take(count).ToListAsync();

        if (getManyEvents is null)
            throw new Exception("No Events found");

        return getManyEvents;
    }

    public async Task AddAsync(Event entity)
    {
        var addEvent = await context.Events.AddAsync(entity);
        context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Event entity)
    {
        var oldEvent = await context.Events.FindAsync(entity.Id);

        if (oldEvent is null)
            throw new Exception("No Event found with that ID");

        context.Entry(oldEvent).CurrentValues.SetValues(entity);
        context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var eventToDelete = await context.Events.FindAsync(id);

        if (eventToDelete is null)
            throw new Exception("No Event found with that ID");

        context.Events.Remove(eventToDelete);
        context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Event>> GetEventByName(string name)
    {
        var eventByName = await context.Events.ToListAsync();

        var fuzzyScored = eventByName.Select(x => new
            {
                Score = FuzzySharp.Fuzz.PartialRatio(x.Name, name),
                Event = x
            })
            .Where(x => x.Score > 80)
            .OrderByDescending(x => x.Score)
            .Select(x => x.Event);

        return eventByName;
    }
}