using Blazor8Issue_LargeContent;
using Microsoft.AspNetCore.Components.Endpoints;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorComponents();

var app = builder.Build();


app.UseStaticFiles();

app.MapGet("/ok", () => new RazorComponentResult<App>(new Dictionary<string, object?> { { "Count", 10 } }));
app.MapGet("/", () => new RazorComponentResult<App>(new Dictionary<string, object?> { { "Count", 50 } }));

app.Run();
