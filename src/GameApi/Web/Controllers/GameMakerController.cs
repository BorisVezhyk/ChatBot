using GameApi.DataAccess;
using GameApi.DataAccess.Entities;
using GameApi.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameApi.Web.Controllers
{
	/// <summary>
	/// The Game maker controller.
	/// </summary>
	/// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
	[ApiController]
	[Route("[controller]")]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	public class GameMakerController : ControllerBase
	{
		#region Private fields

		private readonly IDataAccessService _dataAccessService;
		private readonly ILogger<GameMakerController> _logger;

		#endregion

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="GameMakerController"/> class.
		/// </summary>
		/// <param name="dataAccessService">The data access service.</param>
		/// <param name="logger">The logger.</param>
		public GameMakerController(IDataAccessService dataAccessService, ILogger<GameMakerController> logger)
		{
			_dataAccessService = dataAccessService;
			_logger = logger;
		}

		#endregion
		#region GameMethods

		/// <summary>
		/// Creates the game.
		/// </summary>
		[HttpPost("Game")]
		[ProducesResponseType(typeof(GameResponse),StatusCodes.Status201Created)]
		public async Task<IActionResult> CreateGame(
			[FromBody] GameRequest request, 
			CancellationToken cancellationToken)
		{
			Game result = await _dataAccessService.CreateGameAsync(MapGame(request), cancellationToken);
			return Created($"Game/{result.Id}", GameResponseMap(result));
		}

		/// <summary>
		/// Updates the game.
		/// </summary>
		/// <param name="gameId">The game identifier.</param>
		/// <param name="updateGame">The update game.</param>
		/// <param name="cancellationToken">The cancellation token.</param>
		[HttpPut("Game/{gameId}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<IActionResult> UpdateGameAsync(
			[FromRoute] long gameId, 
			[FromBody] GameRequest updateGame,
			CancellationToken cancellationToken)
		{
			await _dataAccessService.UpdatedGameAsync(gameId, MapGame(updateGame),cancellationToken);

			return Ok();
		}

		/// <summary>
		/// Gets the game asynchronous.
		/// </summary>
		/// <param name="gameId">The game identifier.</param>
		/// <param name="cancellationToken">The cancellation token.</param>
		[HttpGet("Game/{gameId}")]
		[ProducesResponseType(typeof(GameResponse), StatusCodes.Status200OK)]
		public async Task<IActionResult> GetGameAsync([FromRoute]long gameId, CancellationToken cancellationToken)
		{
			Game result = await _dataAccessService.GetGameAsync(gameId, cancellationToken);
			return Ok(GameResponseMap(result));
		}

		#endregion

		#region Private methods

		private static Game MapGame(GameRequest request)
		{
			return new Game()
			{
				Name = request.Name,
				Description = request.Description,
				FinishDate = request.FinishDate,
				StartDate = request.StartDate,
			};
		}

		private static GameResponse GameResponseMap(Game result)
		{
			GameResponse response = new()
			{
				GameId = result.Id,
				Name = result.Name,
				Description = result.Description,
				Status = result.Status,
				StartDate = result.StartDate,
				FinishDate = result.FinishDate
			};
			return response;
		} 

		#endregion
	}
}