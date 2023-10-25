using GameApi.DataAccess.Entities;
using GameApi.Web.Models;

namespace GameApi.DataAccess;

/// <summary>
/// The interface of data access service.
/// </summary>
public interface IDataAccessService
{
	/// <summary>
	/// Creates a new game.
	/// </summary>
	/// <param name="game">The new game.</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	Task<Game> CreateGameAsync(Game game, CancellationToken cancellationToken);

	/// <summary>
	/// Updateds the game asynchronous.
	/// </summary>
	/// <param name="gameId">The game identifier.</param>
	/// <param name="game">The game.</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	Task UpdatedGameAsync(long gameId, Game game, CancellationToken cancellationToken);

	/// <summary>
	/// Gets the game asynchronous.
	/// </summary>
	/// <param name="gameId">The game identifier.</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	Task<Game> GetGameAsync(long gameId, CancellationToken cancellationToken);
}