using GameApi.DataAccess;
using GameApi.DataAccess.Entities;
using GameApi.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameApi.Web.Controllers
{
	/// <summary>
	/// The Game controller.
	/// </summary>
	/// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
	[ApiController]
	[Route("[controller]")]
	public class GameController : ControllerBase
	{
		#region Private fields

		private readonly IDataAccessService _dataAccessService;
		private readonly ILogger<GameController> _logger;

		#endregion

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="GameController"/> class.
		/// </summary>
		/// <param name="dataAccessService">The data access service.</param>
		/// <param name="logger">The logger.</param>
		public GameController(IDataAccessService dataAccessService, ILogger<GameController> logger)
		{
			_dataAccessService = dataAccessService;
			_logger = logger;
		}

		#endregion
		#region GameMethods

		/// <summary>
		/// Creates the game.
		/// </summary>
		[HttpPost(Name = "CreateGame")]
		public async Task<IActionResult> CreateGame([FromBody] GameRequest request)
		{
			Game result = await _dataAccessService.CreateGameAsync(new Game()
			{
				Name = request.Name,
				Description = request.Description,
				FinishDate = request.FinishDate,
				StartDate = request.StartDate,
			});
			return Ok(result);
		}

		#endregion
	}
}