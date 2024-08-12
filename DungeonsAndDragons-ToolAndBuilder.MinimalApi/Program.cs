using DungeonsAndDragons_ToolAndBuilder.MinimalApi.Extensions;
using DungeonsAndDragons_ToolAndBuilder.SQL;
using DungeonsAndDragons_ToolAndBuilder.SQL.InterfaceRepositories;
using DungeonsAndDragons_ToolAndBuilder.SQL.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DnDToolAndBuilder");
builder.Services.AddDbContext<DnDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddScoped<ICharacterRepository,CharacterRepository>();
builder.Services.AddScoped<IMonsterRepository,MonsterRepository>();








var app = builder.Build();
app.MapCharacterEndpoints();
app.MapMonsterEndpoints();


app.UseHttpsRedirection();
app.Run();

