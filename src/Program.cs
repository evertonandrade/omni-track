var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHealthChecks();

var app = builder.Build();
app.MapGet("/", () => "Welcome to Omni Track!");
app.MapHealthChecks("/healthz");

app.Run();
