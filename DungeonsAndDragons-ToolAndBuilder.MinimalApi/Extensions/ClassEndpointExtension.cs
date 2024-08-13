using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

namespace DungeonsAndDragons_ToolAndBuilder.MinimalApi.Extensions;

public static class ClassEndpointExtension
{
    public static IEndpointRouteBuilder MapClassEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("api/Class");

        return app;
    }
    private static async Task<IResult> GetAllClasses(ClassRepository classRepository)
    {
        var allClasses = await classRepository.GetAllAsync();

        return Results.Ok(allClasses);
    }
    private static async Task<IResult> GetClassById(ClassRepository repo, int id)
    {
        var classById = await repo.GetByIdAsync(id);

        return Results.Ok(classById);
    }
    private static async Task<IResult> GetManyClasses(ClassRepository repo, int start, int count)
    {
        var manyClasses = await repo.GetMany(start, count);

        return Results.Ok(manyClasses);
    }
    private static async Task<IResult> GetClassByName(ClassRepository repo, string name)
    {
        var classByName = await repo.GetClassByName(name);

        return Results.Ok(classByName);
    }
    private static async Task<IResult> GetAllPre5EClasses(ClassRepository repo)
    {
        var pre5EClasses = await repo.GetAllPre5EClasses();

        return Results.Ok(pre5EClasses);
    }
    private static async Task<IResult> AddClass(ClassRepository repo, Class entity)
    {
        await repo.AddAsync(entity);

        return Results.Created($"/api/Class/{entity.Id}", entity);
    }
    private static async Task<IResult> UpdateClass(ClassRepository repo, Class entity)
    {
        await repo.UpdateAsync(entity);

        return Results.Ok(entity);
    }
    private static async Task<IResult> DeleteClass(ClassRepository repo, int id)
    {
        await repo.DeleteAsync(id);

        return Results.NoContent();
    }
}