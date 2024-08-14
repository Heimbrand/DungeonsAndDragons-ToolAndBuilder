using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

namespace DungeonsAndDragons_ToolAndBuilder.MinimalApi.Extensions;

public static class ConditionEndpointExtensions
{
    public static IEndpointRouteBuilder MapConditionEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("api/Conditions");

        group.MapGet("/{id}", GetConditionsById);
        group.MapGet("", GetAllConditions);
        group.MapGet("/GetMany/{start}/{count}", GetManyConditions);
        group.MapGet("/GetByName/{name}", GetConditionByName);
        group.MapGet("/GetPre5e/{start}/{count}", GetManyPre5eConditions);
        group.MapPost("/", AddCondition);
        group.MapPut("/", UpdateCondition);
        group.MapDelete("/{id}", DeleteCondition);

        return app;

    }
    private static async Task<IResult> GetConditionsById(ConditionRepository repo,int id)
    {
        var conditionById = await repo.GetByIdAsync(id);

        if (conditionById is null)
            return Results.NotFound();

        return Results.Ok(conditionById);
    }
    private static async Task<IResult> GetAllConditions(ConditionRepository repo)
    {
        var allConditions = await repo.GetAllAsync();

        if (allConditions is null)
            return Results.NotFound();

        return Results.Ok(allConditions);
    }
    private static async Task<IResult> GetManyConditions(ConditionRepository repo, int start, int count)
    {
        var getManyConditions = await repo.GetMany(start, count);

        if (getManyConditions is null)
            return Results.NotFound();

        return Results.Ok(getManyConditions);
    }
    private static async Task<IResult> AddCondition(ConditionRepository repo, Condition entity)
    {
        await repo.AddAsync(entity);

        return Results.Created($"/api/Conditions/{entity.Id}", entity);
    }
    private static async Task<IResult> UpdateCondition(ConditionRepository repo, Condition entity)
    {
        await repo.UpdateAsync(entity);

        return Results.Ok(entity);
    }
    private static async Task<IResult> DeleteCondition(ConditionRepository repo, int id)
    {
        await repo.DeleteAsync(id);

        return Results.NoContent();
    }
    private static async Task<IResult> GetConditionByName(ConditionRepository repo, string name)
    {
        var conditionByName = await repo.GetConditionByName(name);

        if (conditionByName is null)
            return Results.NotFound();

        return Results.Ok(conditionByName);
    }
    private static async Task<IResult> GetManyPre5eConditions(ConditionRepository repo, int start, int count)
    {
        var getManyPre5eConditions = await repo.GetManyPre5EConditions(start, count);

        if (getManyPre5eConditions is null)
            return Results.NotFound();

        return Results.Ok();
    }
}