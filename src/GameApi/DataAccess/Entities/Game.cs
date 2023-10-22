using System.ComponentModel.DataAnnotations;

namespace GameApi.DataAccess.Entities;

public class Game
{
	public long Id { get; set; }
	public string? Name { get; set; }
	public string? Description { get; set; }
	public DateTime StartDate { get; set; }
	public DateTime FinishDate { get; set; }
	public ICollection<Level> Levels { get; set; } = new List<Level>();
}