using GameApi.DataAccess.Entities;
using GameApi.Web.Models;
using Microsoft.EntityFrameworkCore;
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

	///<inheritdoc/>
	public async Task<Game> CreateGameAsync(Game game, CancellationToken cancellationToken)
	{
		game.Status = 'N';
		EntityEntry<Game> newGame = _gameDb.Games.Add(game);
		await _gameDb.SaveChangesAsync(cancellationToken);
		return newGame.Entity;
	}

	///<inheritdoc/>
	public async Task UpdatedGameAsync(long gameId, Game game, CancellationToken cancellationToken)
	{
		Game? updatedGame = await _gameDb.Games.FirstOrDefaultAsync(x => x.Id == gameId, cancellationToken);
		if (updatedGame is null)
		{
			//todo create custom NotFoundException and change it here.
			throw new InvalidOperationException();
		}
		updatedGame.StartDate = game.StartDate;
		updatedGame.FinishDate = game.FinishDate;
		updatedGame.Description = game.Description;
		updatedGame.Name = game.Name;
		await _gameDb.SaveChangesAsync(cancellationToken);
	}

	///<inheritdoc/>
	public async Task<Game> GetGameAsync(long gameId, CancellationToken cancellationToken)
	{
		Game? result = await _gameDb.Games.FirstOrDefaultAsync(x => x.Id == gameId, cancellationToken);
		if (result is null)
		{
			//todo create custom NotFoundException and change it here.
			throw new InvalidOperationException();
		}
		return result;
	}

	#endregion

}