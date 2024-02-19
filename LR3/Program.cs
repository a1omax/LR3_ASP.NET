using ASP.NET.interfaces;
using ASP.NET.services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<ICalcService, CalcService>();
builder.Services.AddTransient<IDayTimeAnalyzer, DayTimeAnalyzerService>();
var app = builder.Build();




app.MapGet("/", async context => context.Response.Redirect("/calc/"));
app.MapGet("/calc/", async context =>
{
    var calcService = app.Services.GetService<ICalcService>();
    await context.Response.WriteAsync($"Add: {calcService?.Add(6, 2)}\n");
    await context.Response.WriteAsync($"Mult: {calcService?.Multiply(5f, 2f)}\n");
    await context.Response.WriteAsync($"Sub: {calcService?.Subtract(31, 2)}\n");
    await context.Response.WriteAsync($"Div: {calcService?.Divide(1.0, 6.0)}\n");
});

app.MapGet("/time/", async context =>
{
    var dayTimeService = app.Services.GetService<IDayTimeAnalyzer>();
    await context.Response.WriteAsync($"Daytime: {dayTimeService?.GetTimeInHumanForm(DateTime.Now)}\n");
});

app.Run();
