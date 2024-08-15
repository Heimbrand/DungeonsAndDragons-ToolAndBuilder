using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

namespace DungeonsAndDragons_ToolAndBuilder.MinimalApi.Extensions;

public static class DungeonMasterEndpointExtensions
{
    public static IEndpointRouteBuilder MapDungeonMasterEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("api/DungeonMaster");

        group.MapGet("", GetAllDungeonMasters);
        group.MapGet("{id}", GetDungeonMasterById);
        group.MapGet("{start}/{count}", GetManyDungeonMasters);
        group.MapPost("", AddDungeonMaster);
        group.MapPut("", UpdateDungeonMaster);
        group.MapDelete("{id}", DeleteDungeonMaster);

        return app;

    }
    private static async Task<IResult> GetAllDungeonMasters(DungeonMasterRepository repo)
    {
        var allDungeonMasters = await repo.GetAllAsync();

        return Results.Ok(allDungeonMasters);
    }
    private static async Task<IResult> GetDungeonMasterById(DungeonMasterRepository repo, int id)
    {
        var dmById = await repo.GetByIdAsync(id);

        return Results.Ok(dmById);
    }
    private static async Task<IResult> GetManyDungeonMasters(DungeonMasterRepository repo, int start, int count)
    {
        var manyDungeonMasters = await repo.GetMany(start, count);

        return Results.Ok(manyDungeonMasters);
    }
    private static async Task<IResult> AddDungeonMaster(DungeonMasterRepository repo, DungeonMaster dm)
    {
        await repo.AddAsync(dm);

        return Results.Created($"/api/DungeonMaster/{dm.Id}", dm);
    }
    private static async Task<IResult> UpdateDungeonMaster(DungeonMasterRepository repo, DungeonMaster dm)
    {
        await repo.UpdateAsync(dm);

        return Results.Ok(dm);
    }
    private static async Task<IResult> DeleteDungeonMaster(DungeonMasterRepository repo, int id)
    {
        await repo.DeleteAsync(id);

        return Results.NoContent();
    }
    
}