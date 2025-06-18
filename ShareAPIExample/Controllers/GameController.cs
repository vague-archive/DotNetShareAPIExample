using Microsoft.AspNetCore.Mvc;
using ShareAPIExample.Models;
using ShareAPIExample.Services;

namespace ShareAPIExample.Controllers;

[ApiController]
[Route("/api/v1/games")]
public class GameController(IGameService gameService) : Controller
{
    /// <summary>
    /// Get all games
    /// </summary>
    [HttpGet]
    public async Task<ActionResult<List<Game>>> All()
    {
        return Ok(await gameService.GetAllAsync());
    }
    
    /// <summary>
    /// Get one game by ID
    /// </summary>
    [HttpGet("{id:guid}")]
    public async Task<ActionResult<Game>> GetOne(Guid id)
    {
        return Ok(await gameService.GetAsync(id));
    }

    /// <summary>
    /// Create a new game
    /// </summary>
    [HttpPost]
    public async Task<ActionResult<Game>> Create(CreateGameRequest game)
    {
        return Ok(await gameService.CreateAsync(game.Title));
    }
}