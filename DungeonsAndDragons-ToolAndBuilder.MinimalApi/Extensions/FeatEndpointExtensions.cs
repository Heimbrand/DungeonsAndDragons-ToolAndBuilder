using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

namespace DungeonsAndDragons_ToolAndBuilder.MinimalApi.Extensions;

public static class FeatEndpointExtensions
{

    public static IEndpointRouteBuilder MapFeatEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("api/Feats");

        group.MapGet("", GetAllFeats);
        group.MapGet("{id}", GetFeatById);
        group.MapGet("many/{start}/{count}", GetManyFeats);
        group.MapGet("name/{name}", GetFeatByName);
        group.MapPost("", AddFeat);
        group.MapPut("", UpdateFeat);
        group.MapDelete("{id}", DeleteFeat);
        group.MapGet("pre5e/{start}/{count}", GetManyPre5eFeats);
        group.MapGet("5e", GetAll5eFeats);

        return app;
    }
    private static async Task<IResult> GetAllFeats(FeatRepository repo)
    {
        var allFeats = await repo.GetAllAsync();

        if (allFeats is null)
            return Results.NotFound("No Feats found");

        return Results.Ok(allFeats);
    }
    private static async Task<IResult> GetFeatById(FeatRepository repo, int id)
    {
        var featById = await repo.GetByIdAsync(id);

        if (featById is null)
            return Results.NotFound("No Feat found with that ID");

        return Results.Ok(featById);
    }
    private static async Task<IResult> GetManyFeats(FeatRepository repo, int start, int count)
    {
        var manyFeats = await repo.GetMany(start, count);

        if (manyFeats is null)
            return Results.NotFound("No Feats found");

        return Results.Ok(manyFeats);
    }
    private static async Task<IResult> GetFeatByName(FeatRepository repo, string name)
    {
        var featByName = await repo.GetFeatByName(name);

        if (featByName is null)
            return Results.NotFound("No Feat found with that name");

        return Results.Ok(featByName);
    }
    private static async Task<IResult> AddFeat(FeatRepository repo, Feat feat)
    {
        await repo.AddAsync(feat);

        return Results.Created($"/api/Feats/{feat.Id}", feat);
    }
    private static async Task<IResult> UpdateFeat(FeatRepository repo, Feat feat)
    {
        await repo.UpdateAsync(feat);

        return Results.Ok(feat);
    }
    private static async Task<IResult> DeleteFeat(FeatRepository repo, int id)
    {
        await repo.DeleteAsync(id);

        return Results.NoContent();
    }
    private static async Task<IResult> GetManyPre5eFeats(FeatRepository repo, int start, int count)
    {
        var manyPre5eFeats = await repo.GetManyPre5EFeats(start, count);

        if (manyPre5eFeats is null)
            return Results.NotFound("No Feats found");

        return Results.Ok(manyPre5eFeats);
    }
    private static async Task<IResult> GetAll5eFeats(FeatRepository repo)
    {
        var many5eFeats = await repo.GetAllPre5EFeats();

        if (many5eFeats is null)
            return Results.NotFound("No Feats found");

        return Results.Ok(many5eFeats);
    }
}