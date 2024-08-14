using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL;
using DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

namespace DungeonsAndDragons_ToolAndBuilder.MinimalApi.Extensions;

public static class ConsumableEndpointExtensions
{
    public static IEndpointRouteBuilder MapConsumableEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("api/Consumables");

        group.MapGet("/{id}", GetConsumableByIdAsync);
        group.MapGet("", GetAllConsumablesAsync);
        group.MapGet("/GetMany/{start}/{count}", GetManyConsumablesAsync);
        group.MapPost("", AddConsumableAsync);
        group.MapPut("", UpdateConsumableAsync);
        group.MapDelete("/{id}", DeleteConsumableAsync);
        group.MapGet("/GetByName/{name}", GetConsumableByNameAsync);
        group.MapGet("/GetByType/{type}", GetConsumablesByTypeAsync);
        group.MapGet("/GetByRarity/{rarity}", GetConsumablesByRarityAsync);
        group.MapGet("/GetManyByType/{type}/{start}/{count}", GetManyConsumablesByType);
        group.MapGet("/GetManyPre5eByType/{type}/{start}/{count}", GetManyPre5eConsumablesByType);

        return app;
    }

    private static async Task<IResult> GetConsumableByIdAsync(ConsumableRepository repo, int id)
    {
        var consumableById = await repo.GetByIdAsync(id);

        if (consumableById is null)
            throw new Exception("No Consumable found with that ID");

        return Results.Ok(consumableById);
    }

    private static async Task<IResult> GetAllConsumablesAsync(ConsumableRepository repo)
    {
        var allConsumables = await repo.GetAllAsync();

        if (allConsumables is null)
            throw new Exception("No Consumables found");

        return Results.Ok(allConsumables);
    }

    private static async Task<IResult> GetManyConsumablesAsync(ConsumableRepository repo, int start, int count)
    {
        var getManyConsumables = await repo.GetMany(start, count);

        if (getManyConsumables is null)
            throw new Exception("No Consumables found");

        return Results.Ok(getManyConsumables);
    }

    private static async Task<IResult> AddConsumableAsync(ConsumableRepository repo, Consumable entity)
    {
        await repo.AddAsync(entity);

        return Results.Created($"/api/Consumables/{entity.Id}", entity);
    }

    private static async Task<IResult> UpdateConsumableAsync(ConsumableRepository repo, Consumable entity)
    {
        await repo.UpdateAsync(entity);

        return Results.Ok(entity);
    }

    private static async Task<IResult> DeleteConsumableAsync(ConsumableRepository repo, int id)
    {
        await repo.DeleteAsync(id);

        return Results.NoContent();
    }

    private static async Task<IResult> GetConsumableByNameAsync(ConsumableRepository repo, string name)
    {
        var consumableByName = await repo.GetConsumableByName(name);

        if (consumableByName is null)
            throw new Exception("No Consumable found with that name");

        return Results.Ok(consumableByName);
    }

    private static async Task<IResult> GetConsumablesByTypeAsync(ConsumableRepository repo, string type)
    {
        var consumableByType = await repo.GetAllConsumablesByType(type);

        if (consumableByType is null)
            throw new Exception("No Consumable found with that type");

        return Results.Ok(consumableByType);
    }

    private static async Task<IResult> GetConsumablesByRarityAsync(ConsumableRepository repo, string rarity)
    {
        var consumableByRarity = await repo.GetConsumablesByRarity(rarity);

        if (consumableByRarity is null)
            throw new Exception("No Consumable found with that rarity");

        return Results.Ok(consumableByRarity);
    }

    private static async Task<IResult> GetManyConsumablesByType(ConsumableRepository repo, string type, int start, int count)
    {
        var getManyConsumablesByType = await repo.GetManyConsumablesByType(type, start, count);

        if (getManyConsumablesByType is null)
            throw new Exception("No Consumable found with that type");

        return Results.Ok(getManyConsumablesByType);
    }

    private static async Task<IResult> GetManyPre5eConsumablesByType(ConsumableRepository repo,string type, int start, int count)
    {
        var getManyPre5eConsumables = await repo.GetManyPre5EByType(type,start, count);

        if (getManyPre5eConsumables is null)
            throw new Exception("No Consumable found with that type");

        return Results.Ok(getManyPre5eConsumables);
    }
}