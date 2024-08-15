using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;
using Microsoft.Identity.Client;

namespace DungeonsAndDragons_ToolAndBuilder.MinimalApi.Extensions;

public static class EventEndpointExtensions
{

    public static IEndpointRouteBuilder MapEventEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("api/Events");

        group.MapGet("", GetAllEvents);
        group.MapGet("{id}", GetEventById);
        group.MapGet("{start}/{count}", GetManyEvents);
        group.MapPost("", AddEvent);
        group.MapPut("", UpdateEvent);
        group.MapDelete("{id}", DeleteEvent);

        return app;
    }

    private static async Task<IResult> GetAllEvents(EventRepository repo)
    {
        var allEvents = await repo.GetAllAsync();

        if (allEvents is null)
            return Results.NotFound("No Events found");

        return Results.Ok(allEvents);
    }
    private static async Task<IResult> GetEventById(EventRepository repo, int id)
    {
        var eventById = await repo.GetByIdAsync(id);

        if (eventById is null)
            return Results.NotFound("No Event found with that ID");

        return Results.Ok(eventById);
    }
    private static async Task<IResult> GetManyEvents(EventRepository repo, int start, int count)
    {
        var getManyEvents = await repo.GetMany(start, count);

        if (getManyEvents is null)
            return Results.NotFound("No Events found");

        return Results.Ok(getManyEvents);
    }
    private static async Task<IResult> AddEvent(EventRepository repo, Event entity)
    {
        await repo.AddAsync(entity);

        return Results.Created($"/api/Events/{entity.Id}", entity);
    }
    private static async Task<IResult> UpdateEvent(EventRepository repo, Event entity)
    {
        await repo.UpdateAsync(entity);

        return Results.Ok(entity);
    }
    private static async Task<IResult> DeleteEvent(EventRepository repo, int id)
    {
        await repo.DeleteAsync(id);

        return Results.NoContent();
    }
}