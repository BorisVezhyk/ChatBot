namespace GameApi.Web.Models;

/// <summary>
/// The Game Response.
/// </summary>
public class GameResponse
{
	/// <summary>
	/// The game identifier.
	/// </summary>
	public long GameId { get; set; }

	/// <summary>
	/// The name.
	/// </summary>
	public string? Name { get; set; }

	/// <summary>
	/// The description.
	/// </summary>
	public string? Description { get; set; }

	/// <summary>
	/// The start date.
	/// </summary>
	public DateTime StartDate { get; set; }

	/// <summary>
	/// The finish date.
	/// </summary>
	public DateTime? FinishDate { get; set; }

	/// <summary>
	/// The status.
	/// </summary>
	public char Status { get; set; }
}