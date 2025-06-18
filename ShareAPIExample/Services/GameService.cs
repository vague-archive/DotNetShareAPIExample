using ShareAPIExample.Models;

namespace ShareAPIExample.Services;

public interface IGameService
{
    Task<Game> GetAsync(Guid id);
    Task<List<Game>> GetAllAsync();
    Task<Game> CreateAsync(string title);
}

public class GameService : IGameService
{
    public Task<Game> GetAsync(Guid id)
    {
        return Task.FromResult(new Game { Title = "Brick Breaker 3000"});
    }

    public Task<List<Game>> GetAllAsync()
    {
        return Task.FromResult(new List<Game>
        {
            new() { Title = "Brick Breaker 3000" },
            new() { Title = "Tetris 9000" }
        });
    }
    
    public Task<Game> CreateAsync(string title)
    {
        return Task.FromResult(new Game { Title = title });
    }
}