using GameApi.DataAccess.Entities;
using GameApi.Web.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace GameApi.DataAccess;

/// <summary>
/// The Data Access Service
/// </summary>
/// <seealso cref="GameApi.DataAccess.IDataAccessService" />
public class DataAccessService : IDataAccessService
{
	#region Private fields

	private readonly GameDbContext _gameDb;

	#endregion

	#region Constructor

	public DataAccessService(GameDbContext gameDb)
	{
		_gameDb = gameDb;
	}

	#endregion

	#region IDataAccessService members

	/// <summary>
	/// Creates the game.
	/// </summary>
	/// <param name="game">The game.</param>
	public async Task<Game> CreateGameAsync(Game game)
	{
		EntityEntry<Game> newGame = _gameDb.Games.Add(game);
		await _gameDb.SaveChangesAsync();
		return newGame.Entity;
	}

	#endregion
}