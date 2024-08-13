using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

namespace DungeonsAndDragons_ToolAndBuilder.MinimalApi.Extensions;

public static class MonsterEndpointExtensions
{
    public static IEndpointRouteBuilder MapMonsterEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("api/Monsters");

        group.MapGet("/", GetAllMonsters);
        group.MapGet("/{id}", GetMonstersById);
        group.MapGet("/GetMany/{start}/{count}", GetManyMonsters);
        group.MapGet("/GetByName/{name}", GetMonsterByName);
        group.MapGet("/GetByChallengeRating/{challengeRating}", GetMonsterByChallengeRating);
        group.MapGet("/GetByType/{type}", GetMonsterByType);
        group.MapGet("/GetByAlignment/{alignment}", GetMonsterByAlignment);
        group.MapGet("/GetBySize/{size}", GetMonsterBySize);
        group.MapGet("/GetManyPre5E/{start}/{count}", GetManyPre5EMonsters);
        group.MapPost("/", AddMonster);
        group.MapPut("/", UpdateMonster);
        group.MapDelete("/{id}", DeleteMonster);

        return app;
    }
    private static async Task<IResult> GetMonstersById(MonsterRepository repo, int id)
    {
        var monsterById = await repo.GetByIdAsync(id);

        if (monsterById is null)
            return Results.NotFound("No Monster found with that ID");

        return Results.Ok(monsterById);
    }
    private static async Task<IResult> GetAllMonsters(MonsterRepository repo)
    {
        var allMonsters = await repo.GetAllAsync();

        if (allMonsters is null)
            return Results.NotFound("No Monsters found");

        return Results.Ok(allMonsters);
    }
    private static async Task<IResult> GetManyMonsters(MonsterRepository repo, int start, int count)
    {
        var manyMonsters = await repo.GetMany(start, count);

        if (manyMonsters is null)
            return Results.NotFound("No Monsters found");

        return Results.Ok(manyMonsters);
    }
    private static async Task<IResult> AddMonster(MonsterRepository repo, Monster entity)
    {
        await repo.AddAsync(entity);

        return Results.Created($"/api/Monsters/{entity.Id}", entity);
    }
    private static async Task<IResult> UpdateMonster(MonsterRepository repo, Monster entity)
    {
        var oldMonster = await repo.GetByIdAsync(entity.Id);

        if (oldMonster is null)
            return Results.NotFound("No Monster found with that ID");

        await repo.UpdateAsync(entity);

        return Results.Ok(entity);
    }
    private static async Task<IResult> DeleteMonster(MonsterRepository repo, int id)
    {
        var monsterToDelete = await repo.GetByIdAsync(id);

        if (monsterToDelete is null)
            return Results.NotFound("No Monster found with that ID");

        await repo.DeleteAsync(id);
        return Results.Ok($"{monsterToDelete} has been deleted");
    }
    private static async Task<IResult> GetMonsterByName(MonsterRepository repo, Monster entity)
    {
        var monsterByName = await repo.GetMonsterByName(entity.Name);

        if (monsterByName is null)
            return Results.NotFound("No Monster found with that name");

        return Results.Ok(monsterByName);
    }
    private static async Task<IResult> GetMonsterByChallengeRating(MonsterRepository repo, int challengeRating)
    {
        var monsterByChallenge = await repo.GetMonstersByChallengeRating(challengeRating);

        if (monsterByChallenge is null)
            return Results.NotFound("No Monster found with that Challenge Rating");

        return Results.Ok(monsterByChallenge);
    }
    private static async Task<IResult> GetMonsterByType(MonsterRepository repo, string type)
    {
        var monsterByType = await repo.GetMonstersByType(type);

        if (monsterByType is null)
            return Results.NotFound("No Monster found with that type");

        return Results.Ok(monsterByType);
    }
    private static async Task<IResult> GetMonsterByAlignment(MonsterRepository repo, string alignment)
    {
        var monsterByAlignment = await repo.GetMonstersByAlignment(alignment);

        if (monsterByAlignment is null)
            return Results.NotFound("No Monster found with that alignment");

        return Results.Ok(monsterByAlignment);
    }
    private static async Task<IResult> GetMonsterBySize(MonsterRepository repo, string size)
    {
        var monsterBySize = await repo.GetMonstersBySize(size);

        if (monsterBySize is null)
            return Results.NotFound("No Monster found with that size");

        return Results.Ok(monsterBySize);
    }
    private static async Task<IResult> GetManyPre5EMonsters(MonsterRepository repo, int start, int count)
    {
        var manyPre5EMonsters = await repo.GetManyPre5EMonsters(start, count);

        if (manyPre5EMonsters is null)
            return Results.NotFound("No Pre 5E Monsters found");

        return Results.Ok(manyPre5EMonsters);
    }
}