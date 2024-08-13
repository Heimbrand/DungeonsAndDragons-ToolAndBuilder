using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

namespace DungeonsAndDragons_ToolAndBuilder.MinimalApi.Extensions;

public static class ArmorEndpointExtensions
{
    public static IEndpointRouteBuilder MapArmorEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("api/Armors");
        group.MapGet("/", GetAllArmors);
        group.MapGet("/{id}", GetArmorById);
        group.MapGet("/GetMany/{start}/{count}", GetManyArmors);
        group.MapPost("/", AddArmor);
        group.MapPut("/", UpdateArmor);
        group.MapDelete("/{id}", DeleteArmor);

        return app;
    }

    private static async Task<IResult> GetAllArmors(ArmorRepository repo)
    {
        var armors = await repo.GetAllAsync();

        if (armors is null)
            return Results.NotFound("No armors found");

        return Results.Ok(armors);
    }
    private static async Task<IResult> GetArmorById(ArmorRepository repo, int id)
    {
        var armor = await repo.GetByIdAsync(id);

        if (armor is null)
            return Results.NotFound("Armor not found");

        return Results.Ok(armor);
    }
    private static async Task<IResult> GetManyArmors(ArmorRepository repo, int start, int count)
    {
        var armors = await repo.GetMany(start, count);

        if (armors is null)
            return Results.NotFound("No armors found");

        return Results.Ok(armors);
    }
    private static async Task<IResult> AddArmor(ArmorRepository repo, Armor armor)
    {
        await repo.AddAsync(armor);

        return Results.Created($"/api/Armors/{armor.Id}", armor);
    }
    private static async Task<IResult> UpdateArmor(ArmorRepository repo, Armor armor)
    {
        await repo.UpdateAsync(armor);

        return Results.Ok(armor);
    }
    private static async Task<IResult> DeleteArmor(ArmorRepository repo, int id)
    {
        await repo.DeleteAsync(id);

        return Results.NoContent();
    }
    private static async Task<IResult> GetArmorByName(ArmorRepository repo, string name)
    {
        var armors = await repo.GetArmorByName(name);

        if (armors is null)
            return Results.NotFound("No armors found");

        return Results.Ok(armors);
    }
    private static async Task<IResult> GetArmorByType(ArmorRepository repo, string type)
    {
        var armors = await repo.GetArmorByType(type);

        if (armors is null)
            return Results.NotFound("No armors found");

        return Results.Ok(armors);
    }
    private static async Task<IResult> GetArmorByRarity(ArmorRepository repo, string rarity)
    {
        var armorByRarity = await repo.GetArmorByRarity(rarity);

        if (armorByRarity is null)
            return Results.NotFound("No armors found");

        return Results.Ok(armorByRarity);
    }
    private static async Task<IResult> GetArmorByPiece(ArmorRepository repo, string piece)
    {
        var armorByPiece = await repo.GetArmorByPiece(piece);

        if (armorByPiece is null)
            return Results.NotFound("No armors found");

        return Results.Ok(armorByPiece);
    }
    private static async Task<IResult> GetManyPre5EArmors(ArmorRepository repo, int start, int count)
    {
        var pre5EArmors = await repo.GetManyPre5EArmor(start, count);

        if (pre5EArmors is null)
            return Results.NotFound("No armors found");

        return Results.Ok(pre5EArmors);
    }
}