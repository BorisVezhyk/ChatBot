using System.ComponentModel.DataAnnotations;

namespace GameApi.DataAccess.Entities;

/// <summary>
/// The Game.
/// </summary>
public class Game
{
	/// <summary>
	/// Gets or sets the identifier.
	/// </summary>
	public long Id { get; set; }

	/// <summary>
	/// Gets or sets the name.
	/// </summary>
	public string? Name { get; set; }

	/// <summary>
	/// Gets or sets the description.
	/// </summary>
	public string? Description { get; set; }

	/// <summary>
	/// Gets or sets the start date.
	/// </summary>
	public DateTime StartDate { get; set; }

	/// <summary>
	/// Gets or sets the finish date.
	/// </summary>
	public DateTime? FinishDate { get; set; }

	/// <summary>
	/// Gets or sets the levels.
	/// </summary>
	public ICollection<Level> Levels { get; set; } = new List<Level>();
}