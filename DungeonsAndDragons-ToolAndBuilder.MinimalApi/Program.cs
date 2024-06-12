var builder = WebApplication.CreateBuilder(args);

// Dependency inject the extensions

var app = builder.Build();


app.UseHttpsRedirection();



app.Run();

