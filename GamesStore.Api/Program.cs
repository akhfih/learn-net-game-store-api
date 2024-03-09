using GamesStore.Api.Endpoints;
using GamesStore.Api.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IGamesRepository, InMemGamesRepository>();

var ConnString = builder.Configuration.GetConnectionString("GameStoreContext");

var app = builder.Build();

app.MapGamesEndpoints();

app.Run();
