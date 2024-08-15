using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

namespace DungeonsAndDragons_ToolAndBuilder.MinimalApi.Extensions;

public static class FactionEndpointExtensions
{
    public static IEndpointRouteBuilder MapFactionEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("api/Factions");

        group.MapGet("", GetAllFactions);
        group.MapGet("{id}", GetFactionById);
        group.MapGet("many/{start}/{count}", GetManyFactions);
        group.MapGet("pre5e", GetAllPre5eFactions);
        group.MapGet("name/{name}", GetFactionByName);
        group.MapPost("", AddFaction);
        group.MapPut("", UpdateFaction);
        group.MapDelete("{id}", DeleteFaction);

        return app;

    }
    private static async Task<IResult> GetAllFactions(FactionRepository repo)
    {
        var allFactions = await repo.GetAllAsync();

        if (allFactions is null)
            return Results.NotFound("No Factions found");

        return Results.Ok(allFactions);
    }
    private static async Task<IResult> GetFactionById(FactionRepository repo, int id)
    {
        var factionById = await repo.GetByIdAsync(id);

        if (factionById is null)
            return Results.NotFound("No Faction found with that ID");

        return Results.Ok(factionById);
    }
    private static async Task<IResult> GetManyFactions(FactionRepository repo, int start, int count)
    {
        var getManyFactions = await repo.GetMany(start, count);

        if (getManyFactions is null)
            return Results.NotFound("No Factions found");

        return Results.Ok(getManyFactions);
    }
    private static async Task<IResult> AddFaction(FactionRepository repo, Faction entity)
    {
        await repo.AddAsync(entity);

        return Results.Created($"/api/Factions/{entity.Id}", entity);
    }
    private static async Task<IResult> UpdateFaction(FactionRepository repo, Faction entity)
    {
        await repo.UpdateAsync(entity);

        return Results.Ok(entity);
    }
    private static async Task<IResult> DeleteFaction(FactionRepository repo, int id)
    {
        await repo.DeleteAsync(id);

        return Results.NoContent();
    }
    private static async Task<IResult> GetFactionByName(FactionRepository repo, string name)
    {
        var factionByName = await repo.GetFactionByName(name);

        if (factionByName is null)
            return Results.NotFound("No Faction found with that name");

        return Results.Ok(factionByName);
    }
    private static async Task<IResult> GetAllPre5eFactions(FactionRepository repo)
    {
        var allPre5eFactions = await repo.GetAllPre5EFactions();

        if (allPre5eFactions is null)
            return Results.NotFound("No Pre-5e Factions found");

        return Results.Ok(allPre5eFactions);
    }
}