namespace GameApi.DataAccess.Entities;

public class Level
{
	public long Id { get; set; }
	public long GameId { get; set; }
	public Game Game{ get; set; } = null!;
	public string? Name { get; set; }
	public string? Description { get; set; }
	public int OrderNumber { get; set; }
	public long TimeInSec { get; set; }
	public ICollection<Hint> Hints { get; set; } = new List<Hint>();
	public ICollection<Answer> Answers { get; set; } = new List<Answer>();
}