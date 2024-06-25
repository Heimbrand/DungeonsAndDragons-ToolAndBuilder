using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;
using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

public class LocationRepository(DnDbContext context) : ILocationRepository
{
    public async Task<Location> GetByIdAsync(int id)
    {
        var locationById = await context.Locations.FindAsync(id);

        if (locationById is null)
            throw new Exception("No Location found with that ID");

        return locationById;
    }

    public async Task<IEnumerable<Location>> GetAllAsync()
    {
        var allLocations = await context.Locations.ToListAsync();

        if (allLocations is null)
            throw new Exception("No Locations found");

        return allLocations;
    }

    public async Task<IEnumerable<Location>> GetMany(int start, int count)
    {
        var getManyLocations = await context.Locations.Skip(start).Take(count).ToListAsync();

        if (getManyLocations is null)
            throw new Exception("No Locations found");

        return getManyLocations;
    }

    public async Task AddAsync(Location entity)
    {
        var addLocation = await context.Locations.AddAsync(entity);
        context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Location entity)
    {
        var oldLocation = await context.Locations.FindAsync(entity.Id);

        if (oldLocation is null)
            throw new Exception("No Location found with that ID");

        context.Entry(oldLocation).CurrentValues.SetValues(entity);
        context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var locationToDelete = await context.Locations.FindAsync(id);

        if (locationToDelete is null)
            throw new Exception("No Location found with that ID");

        context.Locations.Remove(locationToDelete);
        context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Location>> GetLocationsByAdventure(string adventure)
    {
        var locationsByAdventure = await context.Locations.Where(l => l.RelatedAdventure == adventure).ToListAsync();

        if (locationsByAdventure is null)
            throw new Exception("No Locations found");

        return locationsByAdventure;
    }
}