using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

namespace DungeonsAndDragons_ToolAndBuilder.MinimalApi.Extensions;

public static class DamageTypeEndpointExtensions
{

    public static IEndpointRouteBuilder MapDamageTypeEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("api/DamageTypes");

        group.MapGet("", GetAllDamageTypes);
        group.MapGet("{id}", GetDamageTypesById);
        group.MapGet("{start}/{count}", GetManyDamageTypes);
        group.MapPost("", AddDamageType);
        group.MapPut("", UpdateDamageType);
        group.MapDelete("{id}", DeleteDamageType);

        return app;
    }
    private static async Task<IResult> GetDamageTypesById(DamageTypeRepository repo,int id)
    {
        var damageTypeById = await repo.GetByIdAsync(id);

        if (damageTypeById is null)
            return Results.NotFound();

        return Results.Ok(damageTypeById);
    }
    private static async Task<IResult> GetAllDamageTypes(DamageTypeRepository repo)
    {
        var allDamageTypes = await repo.GetAllAsync();

        if (allDamageTypes is null)
            return Results.NotFound();

        return Results.Ok(allDamageTypes);
    }
    private static async Task<IResult> GetManyDamageTypes(DamageTypeRepository repo, int start, int count)
    {
        var getManyDamageTypes = await repo.GetMany(start, count);

        if (getManyDamageTypes is null)
            return Results.NotFound();

        return Results.Ok(getManyDamageTypes);
    }
    private static async Task<IResult> AddDamageType(DamageTypeRepository repo, DamageType entity)
    {
        await repo.AddAsync(entity);

        return Results.Created($"/api/DamageTypes/{entity.Id}", entity);
    }
    private static async Task<IResult> UpdateDamageType(DamageTypeRepository repo, DamageType entity)
    {
        await repo.UpdateAsync(entity);

        return Results.Ok(entity);
    }
    private static async Task<IResult> DeleteDamageType(DamageTypeRepository repo, int id)
    {
        await repo.DeleteAsync(id);

        return Results.NoContent();
    }
    
}