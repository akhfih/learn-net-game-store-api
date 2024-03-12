using GamesStore.Api.Data;
using GamesStore.Api.Endpoints;
using GamesStore.Api.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IGamesRepository, InMemGamesRepository>();

var ConnString = builder.Configuration.GetConnectionString("GameStoreContext");
builder.Services.AddSqlServer<GameStoreContext>(ConnString);
var app = builder.Build();

app.Services.InitializeDb();

app.MapGamesEndpoints();

app.Run();
