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
	Task<Game> CreateGameAsync(Game game);
}