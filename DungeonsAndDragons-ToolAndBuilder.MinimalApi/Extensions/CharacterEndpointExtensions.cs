using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;
using DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

namespace DungeonsAndDragons_ToolAndBuilder.MinimalApi.Extensions;

public static class CharacterEndpointExtensions
{
    public static IEndpointRouteBuilder MapCharacterEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("api/Characters");
        group.MapGet("/", GetAllCharacters);
        group.MapGet("/{id}", GetCharacterById);
        group.MapGet("/GetMany/{start}/{count}", GetManyCharacters);
        group.MapGet("/GetByName/{name}", GetCharacterByName);
        group.MapGet("/GetLiving", GetAllLivingCharacters);
        group.MapGet("/GetDead", GetAllDeadCharacters);
        group.MapPost("/", AddCharacter);
        group.MapPut("/", UpdateCharacter);
        group.MapDelete("/{id}", DeleteCharacter);

        return app;
    }

    private static async Task<IResult> GetAllCharacters(CharacterRepository repo)
    {
        var characters = await repo.GetAllAsync();

        if (characters is null)
            return Results.NotFound("No characters found");

        return Results.Ok(characters);
    }
    private static async Task<IResult> GetCharacterById(CharacterRepository repo, int id)
    {
        var character = await repo.GetByIdAsync(id);

        if (character is null)
            return Results.NotFound("Character not found");

        return Results.Ok(character);
    }
    private static async Task<IResult> GetManyCharacters(CharacterRepository repo, int start, int count)
    {
        var characters = await repo.GetMany(start, count);

        if (characters is null)
            return Results.NotFound("No characters found");

        return Results.Ok(characters);
    }
    private static async Task<IResult> GetCharacterByName(CharacterRepository repo, string name)
    {
        var characters = await repo.GetCharacterByName(name);

        if (characters is null)
            return Results.NotFound("No characters found");

        return Results.Ok(characters);
    }
    private static async Task<IResult> GetAllLivingCharacters(CharacterRepository repo)
    {
        var characters = await repo.GetAllLivingCharacters();

        if (characters is null)
            return Results.NotFound("No living characters found");

        return Results.Ok(characters);
    }
    private static async Task<IResult> GetAllDeadCharacters(CharacterRepository repo)
    {
        var characters = await repo.GetAllDeadCharacters();

        if (characters is null)
            return Results.NotFound("No dead characters found");

        return Results.Ok(characters);
    }
    private static async Task<IResult> AddCharacter(CharacterRepository repo, Character newCharacter)
    {
        if (newCharacter is null)
            return Results.BadRequest("Character is null");

        await repo.AddAsync(newCharacter);

        return Results.Ok(newCharacter);
    }
    private static async Task<IResult> UpdateCharacter(CharacterRepository repo, Character updateCharacter)
    {
        if (updateCharacter is null)
            return Results.BadRequest("Character is null");

        await repo.UpdateAsync(updateCharacter);

        return Results.Ok(updateCharacter);
    }
    private static async Task<IResult> DeleteCharacter(CharacterRepository repo, int id)
    {
        await repo.DeleteAsync(id);

        return Results.Ok();
    }

}