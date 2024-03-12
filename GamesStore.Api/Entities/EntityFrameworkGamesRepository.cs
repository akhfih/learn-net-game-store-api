using GamesStore.Api.Data;
using GamesStore.Api.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GamesStore.Api.Entities;

public class EntityFrameworkGamesRepository : IGamesRepository
{
    private readonly GameStoreContext dbContext;

    public EntityFrameworkGamesRepository(GameStoreContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public IEnumerable<Game> GetAll()
    {
        return  dbContext.Games.AsNoTracking().ToList();
    }

    public Game? Get(int id)
    {
        return dbContext.Games.Find(id);
    }

    public void Create(Game game)
    {
        dbContext.Games.Add(game);
        dbContext.SaveChanges();
    }

    public void Update(Game updatedGame)
    {
        dbContext.Update(updatedGame);
        dbContext.SaveChanges();
    }

    public void Delete(int id)
    {
        dbContext.Games.Where(game => game.Id == id)
                       .ExecuteDelete();
    }
}