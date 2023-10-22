using GameApi.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace GameApi.Web.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class GameController : ControllerBase
	{

		private readonly IDataAccessService _dataAccessService;
		private readonly ILogger<GameController> _logger;

		public GameController(IDataAccessService dataAccessService, ILogger<GameController> logger)
		{
			_dataAccessService = dataAccessService;
			_logger = logger;
		}

		/// <summary>
		/// Creates the game.
		/// </summary>
		[HttpPost(Name = "CreateGame")]
		public async Task<IActionResult> CreateGame()
		{
			await _dataAccessService.CreateGame();
			return Ok();
		}
	}
}