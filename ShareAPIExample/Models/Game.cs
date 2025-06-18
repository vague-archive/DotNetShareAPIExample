using System.ComponentModel.DataAnnotations;

namespace ShareAPIExample.Models;

/// <summary>
/// A Game represents metadata about a title - including when it was released, it's title, and the autogened ID.
/// </summary>
public class Game
{
    public string Id { get; set; } = Guid.NewGuid().ToString("D");
    public required string Title { get; set; }
    public DateTime ReleaseDate { get; set; } = DateTime.UtcNow;
}

/// <summary>
/// Create new Game request object
/// </summary>
public class CreateGameRequest
{
    /// <summary>
    /// The title of the Game
    /// </summary>
    [Required, MinLength(3), MaxLength(100)] public string Title { get; set; }
}