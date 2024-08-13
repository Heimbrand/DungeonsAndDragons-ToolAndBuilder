using DungeonsAndDragons_ToolAndBuilder.Shared.Entities;
using DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;

namespace DungeonsAndDragons_ToolAndBuilder.MinimalApi.Extensions;

public static class AlignmentEndpointExtensions
{
    public static IEndpointRouteBuilder MapAlignmentEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("api/Alignments");
        group.MapGet("/", GetAllAlignments);
        group.MapGet("/{id}", GetAlignmentById);
        group.MapGet("/GetByName/{name}", GetAlignmentByName);
        group.MapGet("/GetManyPre5E/{start}/{count}", GetManyPre5EAlignments);
        group.MapGet("/GetMany/{start}/{count}", GetManyAlignments);
        group.MapPost("/", AddAlignment);
        group.MapPut("/", UpdateAlignment);
        group.MapDelete("/{id}", DeleteAlignment);
        
        return app;

    }
    private static async Task<IResult> GetAlignmentById(AlignmentRepository repo, int id)
    {
        var alignmentById = await repo.GetByIdAsync(id);

        if (alignmentById is null)
            return Results.NotFound("No Alignment with that ID exists");

        return Results.Ok(alignmentById);
    }
    private static async Task<IResult> GetAlignmentByName(AlignmentRepository repo, string name)
    {
        var alignmentByName = await repo.GetAlignmentByName(name);

        if (alignmentByName is null)
            return Results.NotFound("No Alignment with that name exists");

        return Results.Ok(alignmentByName);
    }
    private static async Task<IResult> GetManyPre5EAlignments(AlignmentRepository repo, int start, int count)
    {
        var pre5EAlignments = await repo.GetManyPre5EAlignments(start, count);

        if (pre5EAlignments is null)
            return Results.NotFound("No Pre5E Alignments where found");

        return Results.Ok(pre5EAlignments);
    }
    private static async Task<IResult> GetAllAlignments(AlignmentRepository repo)
    {
        var allAlignments = await repo.GetAllAsync();

        if (allAlignments is null)
            return Results.NotFound("No Alignments where found");

        return Results.Ok(allAlignments);
    }
    private static async Task<IResult> GetManyAlignments(AlignmentRepository repo, int start, int count)
    {
        var manyAlignments = await repo.GetMany(start, count);

        if (manyAlignments is null)
            return Results.NotFound("No Alignments where found");

        return Results.Ok(manyAlignments);
    }
    private static async Task<IResult> AddAlignment(AlignmentRepository repo, Alignment alignment)
    {
        await repo.AddAsync(alignment);

        return Results.Created($"/api/Alignments/{alignment.Id}", alignment);
    }
    private static async Task<IResult> UpdateAlignment(AlignmentRepository repo, Alignment alignment)
    {
        await repo.UpdateAsync(alignment);

        return Results.Ok(alignment);
    }
    private static async Task<IResult> DeleteAlignment(AlignmentRepository repo, int id)
    {
        await repo.DeleteAsync(id);

        return Results.NoContent();
    }
}