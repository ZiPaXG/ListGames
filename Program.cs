using ListGames.Models;
using ListGames.Models.Entity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>();

var app = builder.Build();
app.MapGet("/ping", async (context) =>
{
    await context.Response.WriteAsync("pong");
});

app.MapGet("/all", async (HttpContext context, ApplicationDbContext db) =>
{
    return await db.GameEntities.ToListAsync();
});

app.MapGet("/get", async (HttpContext context, ApplicationDbContext db, int id) =>
{
    GameEntity? gameEntity = await db.GameEntities.FirstOrDefaultAsync(t => t.Id == id);
    if (gameEntity != null)
    {
        return gameEntity.ToString();
    }
    return null;
});

app.MapPost("/add", async (HttpContext context, ApplicationDbContext db) =>
{
    GameEntity? gameEntity = await context.Request.ReadFromJsonAsync<GameEntity>();
    if (gameEntity != null)
    {
        db.GameEntities.Add(gameEntity);
        db.SaveChanges();
    }

    return gameEntity;
});

app.MapGet("/delete", async (HttpContext context, ApplicationDbContext db, int id) =>
{
    GameEntity? gameEntity = await db.GameEntities.FirstOrDefaultAsync(t => t.Id == id);
    
    if (gameEntity != null)
    {
        db.GameEntities.Remove(gameEntity);
        db.SaveChanges();
    }
});

app.Run();