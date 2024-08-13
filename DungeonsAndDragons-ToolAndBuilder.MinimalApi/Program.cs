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
builder.Services.AddScoped<IAlignmentRepository, AlignmentRepository>();
builder.Services.AddScoped<IArmorRepository, ArmorRepository>();
builder.Services.AddScoped<IClassRepository, ClassRepository>();








var app = builder.Build();
app.MapCharacterEndpoints();
app.MapMonsterEndpoints();
app.MapAlignmentEndpoints();
app.MapArmorEndpoints();
app.MapClassEndpoints();



app.Run();

