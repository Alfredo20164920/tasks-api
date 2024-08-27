using ef_tasks.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TasksContext>((otp) => otp.UseInMemoryDatabase("TasksDB"));   

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/dbconnection",  ([FromServices] TasksContext dbCtx) => {
    dbCtx.Database.EnsureCreated();
    return Results.Ok("Data Base created: " + dbCtx.Database.IsInMemory());
});

app.Run();
