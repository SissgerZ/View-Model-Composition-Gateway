using ServiceComposer.AspNetCore;

#pragma warning disable ASP0014 // Suggest using top level route registrations

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRouting();
builder.Services.AddViewModelComposition();

var app = builder.Build();

app.UseRouting();
app.UseEndpoints(builder =>
{
    builder.MapCompositionHandlers();
});

app.Run();
