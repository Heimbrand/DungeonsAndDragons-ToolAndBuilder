using DungeonsAndDragons_ToolAndBuilder.SQL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


var connectionString = builder.Configuration.GetConnectionString("DnDToolAndBuilder");
builder.Services.AddDbContext<DnDbContext>(options =>
    options.UseSqlServer(connectionString));








var app = builder.Build();


app.UseHttpsRedirection();



app.Run();

