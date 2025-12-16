var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/hello", () => Results.Ok(new { message = "Hello Bro!" }));

app.Run();
