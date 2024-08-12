namespace DungeonsAndDragons_ToolAndBuilder.MinimalApi.Extensions;

public static class MonsterEndpointExtensions
{
    public static IEndpointRouteBuilder MapMonsterEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("api/Monsters");

        return app;
    }


}