using GamesStore.Api.Entities;
using GamesStore.Api.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GamesStore.Api.Data;

public static class DataExtensions
{
    public static async Task InitializeDbAsync(this IServiceProvider serviceProvider)
    {
        using var scope = serviceProvider.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<GameStoreContext>();
        await dbContext.Database.MigrateAsync();
    }

    public static IServiceCollection AddRepositories(
        this IServiceCollection services, IConfiguration configuration
    )
    {
        var ConnString = configuration.GetConnectionString("GameStoreContext");
        services.AddSqlServer<GameStoreContext>(ConnString)
        .AddScoped<IGamesRepository, EntityFrameworkGamesRepository>();

        return services;
    }
}