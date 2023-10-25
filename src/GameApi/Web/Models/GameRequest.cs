using System.ComponentModel.DataAnnotations;

namespace GameApi.Web.Models;

/// <summary>
/// The game request for create or updated existing game.
/// </summary>
public class GameRequest
{
	/// <summary>
	/// The name of game.
	/// </summary>
	[Required(ErrorMessage = "Name is required.")]
	public string Name { get; set; }= string.Empty;

	/// <summary>
	/// The start date of game.
	/// </summary>
	[Required(ErrorMessage = "StartDate is required.")]
	[DataType(DataType.Date)]
	//todo add validation for StartDate and FinishDate.
	public DateTime StartDate { get; set; }

	/// <summary>
	/// The description.
	/// </summary>
	public string? Description { get; set; }

	/// <summary>
	/// The finish date.
	/// </summary>
	[DataType(DataType.Date)]
	public DateTime? FinishDate { get; set; }
}